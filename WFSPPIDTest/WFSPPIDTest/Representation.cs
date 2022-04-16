using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Ingr.SPPID.Llama;

namespace WFSPPIDTest
{
    public class Representation
    {
        private LMRepresentations representations;
        private LMADataSource dataSource;

        private const string DUMMY = "DUMMY";

        public Representation(LMRepresentations representations)
        {
            this.representations = representations;
            dataSource = representations.DataSource;
        }

        public string GetConnectorId(Point connectionPoint)
        {
            foreach (LMRepresentation representation in representations)
            {
                if (isBranch(representation))
                {
                    LMSymbol branch = getBranch(representation);
                    string id = getConnectorId(branch, connectionPoint);

                    if (id != DUMMY)
                    {
                        return id;
                    }

                    continue;
                }

                if (isConnector(representation))
                {
                    LMConnector connector = dataSource.GetConnector(representation.Id);
                    if (connector.ItemStatus.ToString() == "Active")
                    {
                        string id = findConnectorId(connector, connectionPoint);
                        if (id != DUMMY)
                        {
                            return id;
                        }

                        continue;
                    }
                } 
            }

            return DUMMY;
        }

        public bool isBranch(LMRepresentation representation)
        {
            string type = representation.RepresentationType.ToString();
            return type == "Branch";
        }

        public bool isConnector(LMRepresentation representation)
        {
            string type = representation.RepresentationType.ToString();
            return type == "Connector";
        }

        private LMSymbol getBranch(LMRepresentation representation)
        {
            return dataSource.GetSymbol(representation.Id);
        }

        private string getConnectorId(LMSymbol branch, Point connectionPoint)
        {
            LMConnectors connectors1 = branch.Connect1Connectors;
            LMConnectors connectors2 = branch.Connect2Connectors;

            var branchConnectors = new LMConnectors();

            if (connectors1.Count > 1)
            {
                branchConnectors.AddCollection(connectors1);
            }
            
            if (connectors2.Count >1)
            {
                branchConnectors.AddCollection(connectors2);
            }
      
            foreach(LMConnector connector in branchConnectors)
            {
                if (connector.ItemStatus.ToString() == "Active")
                {
                    string id = findConnectorId(connector, connectionPoint);
                    if (id != DUMMY)
                    {
                        return id;
                    }
                }
            }
     
            return DUMMY;
        }

        private string findConnectorId(LMConnector connector, Point connectionPoint)
        {
            LMConnectorVertices connectorVertices = connector.ConnectorVertices;
            foreach (LMConnectorVertex connectorVertex in connectorVertices)
            {
                double x = (double)connectorVertex.Attributes["XCoordinate"].Value;
                double y = (double)connectorVertex.Attributes["YCoordinate"].Value;

                if (connectionPoint.Y == y && connectionPoint.X < x)
                {
                    return connector.Id;
                }

                if (connectionPoint.X == x && connectionPoint.Y < y)
                {
                    return connector.Id;
                }
            }

            return DUMMY;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Ingr.SPPID.Llama;
using Ingr.SPPID.Plaice;

namespace WFSPPIDTest
{
    public class Connector
    {
        private readonly Placement placement;
        private LMADataSource dataSource;

        public Connector(Placement placement)
        {
            this.placement = placement;
            dataSource = placement.PIDDataSource;
        }

        public LMConnector GetPipeRunConnector(string id, Point connectionPoint)
        {
            LMPipeRun pipeRun = getPipeRun(id);

            var representation = new Representation(pipeRun.Representations);
            string connectorId = representation.GetConnectorId(connectionPoint);

            if (connectorId == "DUMMY")
            {
                throw new Exception($"ConnectorId is DUMMY");
            }

            return dataSource.GetConnector(connectorId);
        } 

        private LMPipeRun getPipeRun(string id)
        {
            if (String.IsNullOrEmpty(id) || id == "DUMMY")
            {
                throw new Exception($"Incorrect piperun ID - {id}"); 
            }

            return dataSource.GetPipeRun(id);
        }
    }
}

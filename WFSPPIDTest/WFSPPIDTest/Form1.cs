using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Ingr.SPPID.Plaice;
using Ingr.SPPID.Llama;
using Ingr.SPPID.LMAutomationUtil;

namespace WFSPPIDTest
{
    public partial class Form1 : Form
    {
        Ingr.SPPID.PIDAuto.Application app;
        private Placement placement;
        private string drawingName = "Test";

        private PipeRun pipeRun;
        private Connector connector;

        public Form1()
        {
            InitializeComponent();
            loadApp();
        }

        private void loadApp()
        {
            try
            {
                app = new Ingr.SPPID.PIDAuto.Application();
                app.Drawings.OpenDrawing(ref drawingName);

                placement = new Placement();
                placement.PIDSnapToTarget = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCreateMainPipeline_Click(object sender, EventArgs e)
        {
            string[] pipelineStartPoint = tbPipelineStartPoint.Text.Split(';');
            string[] pipelineEndPoint = tbPipelineEndPoint.Text.Split(';');

            double x0 = double.Parse(pipelineStartPoint[0]);
            double y0 = double.Parse(pipelineStartPoint[1]);

            double x1 = double.Parse(pipelineEndPoint[0]);
            double y1 = double.Parse(pipelineEndPoint[1]);

            var parentPipelineRunPlaceRunInputs = new PlaceRunInputs();

            parentPipelineRunPlaceRunInputs.AddPoint(x0, y0);
            parentPipelineRunPlaceRunInputs.AddPoint(x1, y1);

            pipeRun = new PipeRun(placement);
            LMPipeRun mainPipeRun = pipeRun.CreatePipeRun(parentPipelineRunPlaceRunInputs);

            TbLogs.AppendText($"Pipeline: The main pipeline has been created. Id-{mainPipeRun.Id}");
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            string parentPipelineId = tbParentPiplineId.Text;
            string[] connectionPoint = tbConnectionPoint.Text.Split(';');
            string[] endPoint = tbBranchEndPoint.Text.Split(';');

            double connectionPointX = double.Parse(connectionPoint[0]);
            double connectionPointY = double.Parse(connectionPoint[1]);

            double endPointX = double.Parse(endPoint[0]);
            double endPointY = double.Parse(endPoint[1]);

            connector = new Connector(placement);
            var connectionPointBranch = new System.Windows.Point(connectionPointX, connectionPointY);

            LMConnector branchConnector = connector.GetPipeRunConnector(parentPipelineId, connectionPointBranch);

            var branchPlaceRunInputs = new PlaceRunInputs();
            branchPlaceRunInputs.AddConnectorTarget(branchConnector, connectionPointBranch.X, connectionPointBranch.Y);
            branchPlaceRunInputs.AddPoint(endPointX, endPointY);

            LMAItem lmaItem = pipeRun.CreateBranch(branchConnector, branchPlaceRunInputs);

            TbLogs.AppendText($"\r\nBranch: The branch has been created. Id-{lmaItem.Id}. " +
                $"StartPoint:({connectionPointX};{connectionPointY}) - EndPoint:({endPointX};{endPointY})");
        }
    }
}

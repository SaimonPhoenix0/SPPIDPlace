using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ingr.SPPID.Llama;
using Ingr.SPPID.Plaice;

namespace WFSPPIDTest
{
    public class PipeRun
    {
        private readonly string definitionFile = @"\Piping\Routing\Process Lines\Primary Piping.sym";
        private readonly Placement placement;
        private LMADataSource dataSource;

        public PipeRun(Placement placement)
        {
            this.placement = placement;
            dataSource = placement.PIDDataSource;
        }

        public LMPipeRun CreatePipeRun(PlaceRunInputs placeRunInputs)
        {
            LMPipeRun pipeRun = null;

            LMAItem lmaPipeRun = placement.PIDCreateItem(definitionFile);
            placement.PIDPlaceRun(lmaPipeRun, placeRunInputs);

            pipeRun = dataSource.GetPipeRun(lmaPipeRun.Id);

            return pipeRun;
        }

        public LMAItem CreateBranch(LMConnector connector, PlaceRunInputs placeRunInputs)
        {
            LMAItem lmItem = placement.PIDCreateItem(definitionFile);
            placement.PIDPlaceRun(lmItem, placeRunInputs);

            return lmItem;
        }
    }
}

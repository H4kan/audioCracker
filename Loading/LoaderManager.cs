using audioCracker.Controls;
using audioCracker.Decoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Loading
{
    public class LoaderManager
    {

        private PlotManager plotManager;
        private ControlManager controlManager;
        private FrameProcessor frameProcessor;

        public LoaderManager(FrameProcessor frameProcessor, PlotManager plotManager, ControlManager controlManager) { 
            this.plotManager = plotManager;
            this.controlManager = controlManager;
            this.frameProcessor = frameProcessor;
        }

        public void StartLoading()
        {
            this.controlManager.EnableControls(false);
            this.controlManager.ShowLoadingPanel(true, this.frameProcessor.GetEstimatedTime());
        }

        public void StopLoading()
        {
            this.controlManager.EnableControls(true);
            this.controlManager.ShowLoadingPanel(false);
        }
    }
}

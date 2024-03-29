﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audioCracker.Controls
{
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    public class Wavplayer
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, StringBuilder returnValue, int uReturnLength, int hwndCallback);


        private bool isAudioPlaying;
        private Button playButton;
        private Button stopButton;
        private DurationChanger durationChanger;
        private int fileSequencer;
        private ControlManager controlManager;
        private PlotManager plotManager;

        public Wavplayer(Button playButton, 
            Button stopButton,
            Label durationLabel,
            Label currentLabel,
            TimeManager timeManager,
            ControlManager controlManager,
            PlotManager plotManager)
        {
            this.playButton = playButton;
            this.stopButton = stopButton;
            this.isAudioPlaying = false;
            this.durationChanger = new DurationChanger(this, durationLabel, currentLabel, timeManager);
            this.fileSequencer = 0;
            this.controlManager = controlManager;
            this.plotManager = plotManager;
        }


        public void Setup(string path)
        {
            if (this.fileSequencer > 0)
            {
                this.Stop();
            }
            this.fileSequencer = this.fileSequencer + 1;
            var durationBuilder = new StringBuilder(32);
            mciSendString($"open \"{path}\" alias Wfile{fileSequencer}", new StringBuilder(), 0, 0);
            mciSendString($"status Wfile{fileSequencer} length", durationBuilder, durationBuilder.Capacity, 0);
            this.isAudioPlaying= false;
            this.controlManager.EnableNonPlayControls(!this.isAudioPlaying);
            int length = 0;
            int.TryParse(durationBuilder.ToString(), out length);
            this.durationChanger.ChangeDuration(length);

            this.controlManager.EnableControls(true);
        }

        public int GetDurationInMs()
        {
            return this.durationChanger.GetDurationInMs();
        }

        public void Play()
        {
            if (!this.isAudioPlaying)
            {
                mciSendString($"play Wfile{fileSequencer}", new StringBuilder(), 0, 0);
                this.playButton.Text = "Pause";
                this.durationChanger.UnpauseCurrentTicker();
            }
            else
            {
                mciSendString($"pause Wfile{fileSequencer}", new StringBuilder(), 0, 0);
                this.playButton.Text = "Play";
                this.durationChanger.PauseCurrentTicker();
            }
            this.isAudioPlaying = !this.isAudioPlaying;
            this.controlManager.EnableNonPlayControls(!this.isAudioPlaying);
        }

        public void Stop()
        {
            mciSendString($"stop Wfile{fileSequencer}", new StringBuilder(), 0, 0);
            mciSendString($"seek Wfile{fileSequencer} to start", new StringBuilder(), 0, 0);
            this.isAudioPlaying = false;
            this.controlManager.EnableNonPlayControls(!this.isAudioPlaying);
            this.durationChanger.ResetCurrentTicker();
            if (this.plotManager.IsLoaded)
            {
                this.plotManager.ShowPlot();
            }

            this.playButton.Text = "Play";
        }
    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
}

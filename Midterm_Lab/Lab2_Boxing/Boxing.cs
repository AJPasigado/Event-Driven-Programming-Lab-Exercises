using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Boxing {
    public partial class Boxing : Form {
        public Boxing() {
            InitializeComponent();
            freshStart();
        }
        SoundPlayer bell = new SoundPlayer(Properties.Resources.bellStart);
        private void freshStart() {
            TTimer.Stop();
            RestTMR.Stop();

            Step1.Enabled = true;
            Step2.Enabled = false;
            Step3.Enabled = false;
            Step4.Enabled = false;
            Step5.Enabled = false;
            Step6.Enabled = false;
            
            TMinBox.Text = "00";
            TSecBox.Text = "00";
            TMilBox.Text = "00";

            RSecBox.Text = "00";
            RMilBox.Text = "00";
        }

        private void RoundAccept_Click(object sender, EventArgs e) {
            if (TimerCombo.Text.Equals("")) {
                MessageBox.Show("Please Select Time");
            } else {
                TMin = int.Parse(TimerCombo.Text);
                Step2.Enabled = true;
            }
        }


        int TMil, TSec, TMin, THour;

        private void RestAccept_Click(object sender, EventArgs e) {
            if (RestTimeBX.Text.Equals("") || int.Parse(RestTimeBX.Text) < 10 || int.Parse(RestTimeBX.Text) > 50) {
                MessageBox.Show("Input 10-50");
            }
            else {
                RMax = int.Parse(RestTimeBX.Text);
                RSecBox.Text = RMax.ToString();
                RSec = RMax;
                Step3.Enabled = true;
            }
        }

        private void TTimer_Tick(object sender, EventArgs e) {
            TMinus();
        }

        private void PlayBTN_Click(object sender, EventArgs e) {
            TTimer.Start();

            Step4.Enabled = true;
            Step5.Enabled = true;
            Step6.Enabled = true;
            Step1.Enabled = false;
            Step2.Enabled = false;
            Step3.Enabled = false;

            
            bell.Play();
        }

        private void TMinus() {
            TMil--;
            if (TMin == 0 && TSec == 0 && TMil == 0) { TTimer.Stop(); RestTMR.Start(); }
            else {
                if (TMil < 0) { TSec--; TMil = 59; }
                if (TSec < 0) { TMin--; TSec = 59; }
                if (TMin < 0) { THour--; TMin = 59; }
                if (THour < 0) { THour = 0; }
            }
            if (TMil < 10) { TMilBox.Text = "0" + TMil.ToString(); }
            else TMilBox.Text = TMil.ToString();
            if (TSec < 10) { TSecBox.Text = "0" + TSec.ToString(); }
            else TSecBox.Text = TSec.ToString();
            if (TMin < 10) { TMinBox.Text = "0" + TMin.ToString(); }
            else TMinBox.Text = TMin.ToString();
        }

        private void RestTMR_Tick(object sender, EventArgs e) {
            TRestMinus();
        }

        private void StopBTN_Click(object sender, EventArgs e) {
            freshStart();
        }

        private void BellBTN_Click(object sender, EventArgs e) {
            
            bell.Play();
        }

        private void PauseBTN_Click(object sender, EventArgs e) {
            if (TTimer.Enabled) {
                TTimer.Stop();
                RestTMR.Stop();
                PauseBTN.Image = Properties.Resources.play;
                bell.Play();
            }
            else {
                TTimer.Start();
                RestTMR.Start();
                PauseBTN.Image = Properties.Resources.pause;
                bell.Play();
            }
        }

        int RMil, RSec, RMax;

        private void TRestMinus() {
            RMil--;
            if (RSec == 0 && RMil == 0) { THour = 0;  TMin = int.Parse(TimerCombo.Text); TTimer.Start(); RestTMR.Stop(); }
            else {
                if (RMil < 0) { RSec--; RMil = 59; }
            }
            if (RMil < 10) { RMilBox.Text = "0" + RMil.ToString(); }
            else RMilBox.Text = RMil.ToString();
            if (RSec < 10) { RSecBox.Text = "0" + RSec.ToString(); }
            else RSecBox.Text = RSec.ToString();
        }
    }
}

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

namespace Midterm_Lab {
    public partial class SimpleGame : Form {
        public SimpleGame() {
            InitializeComponent();
            EnableButtons(true);
            PlayBTN.Enabled = false;
            AgainBTN.Enabled = false;
            SetBTN.Enabled = false;
        }

        int Mil;
        int Sec;
        int Min;
        int MaxSec = 10;
        int PicIndex;
        int ChosenIndex = 3;

        SoundPlayer clap = new SoundPlayer(Properties.Resources.Clap);
        SoundPlayer crazyclap = new SoundPlayer(Properties.Resources.CrazyClap);
        SoundPlayer laugh = new SoundPlayer(Properties.Resources.Laugh);
        SoundPlayer laughter = new SoundPlayer(Properties.Resources.Laughter);

        private void EnableButtons(bool chose) {
            PaperBTN.Enabled = chose;
            RockBTN.Enabled = chose;
            ScissorsBTN.Enabled = chose;
        }
        

        private void SWadd() {
            Mil++;
            if (Mil % 60 == 0 && Mil != 0) { Mil = 00; Sec++; }
            if (Sec % 60 == 0 && Sec != 0) { Sec = 00; Min++; }
            if (Min % 60 == 0 && Min != 0) { Min = 00; }
            if (Mil < 10) { MilBox.Text = "0" + Mil.ToString(); }
            else MilBox.Text = Mil.ToString();
            if (Sec < 10) { SecBox.Text = "0" + Sec.ToString(); }
            else SecBox.Text = Sec.ToString();
            if (Min < 10) { MinBox.Text = "0" + Min.ToString(); }
            else MinBox.Text = Min.ToString();
        }
        private void GameBTN_Click(object sender, EventArgs e) {
            AgainBTN.Enabled = true;
            TimeTMR.Start();
            PicTimer.Start();
            EnableButtons(true);
        }

        private void StartAgain() {
            EnableButtons(true);
            Mil = 0;
            Sec = 0;
            Min = 0;
            MaxSec = 10;
            ChosenIndex = 3;
            PicTimer.Start();
            MinBox.Text = "00";
            SecBox.Text = "00";
            MilBox.Text = "00";
            PlayBTN.Enabled = false;
            PlayerPIC.Image = Properties.Resources.Hide;
            TimeTMR.Start();
        }

        private void TimeTMR_Tick(object sender, EventArgs e) {
            if (Sec == MaxSec) {
                TimeTMR.Stop(); Score();
            } else SWadd();
        }

        private void PicTimer_Tick(object sender, EventArgs e) {
            PicIndex = Mil % 3;
            if (PicIndex == 0) {
                CompPIC.Image = Properties.Resources.rock;
            } else if (PicIndex == 1) {
                CompPIC.Image = Properties.Resources.paper;
            } else if (PicIndex == 2) {
                CompPIC.Image = Properties.Resources.scissors;
            }
        }

        private void PaperBTN_Click(object sender, EventArgs e) {
            PlayerPIC.Image = Properties.Resources.paper;
            ChosenIndex = 1;
            PlayBTN.Enabled = true;
        }

        private void RockBTN_Click(object sender, EventArgs e) {
            PlayerPIC.Image = Properties.Resources.rock;
            ChosenIndex = 0;
            PlayBTN.Enabled = true;

           

        }

        private void ScissorsBTN_Click(object sender, EventArgs e) {
            PlayerPIC.Image = Properties.Resources.scissors;
            ChosenIndex = 2;
            PlayBTN.Enabled = true;
        }

        private void SetBTN_Click(object sender, EventArgs e) {
            MaxSec = int.Parse(InputTXTBX.Text);
            StartAgain();
        }
        
        private void PlayBTN_Click(object sender, EventArgs e) {
            PlayBTN.Enabled = false;
            AgainBTN.Enabled = true;
            Score();
        }

        private void Score() {
            TimeTMR.Stop();
            PicTimer.Stop();
            EnableButtons(false);
            if (PicIndex == 0 && ChosenIndex == 1) {
                PlayerScoreLBL.Text = (int.Parse(PlayerScoreLBL.Text) + 1).ToString();
                PlaySounds(1);
            }
            else if (PicIndex == 0 && ChosenIndex == 2) {
                CompScoreLBL.Text = (int.Parse(CompScoreLBL.Text) + 1).ToString();
                PlaySounds(2);
            }
            else if (PicIndex == 1 && ChosenIndex == 0) {
                CompScoreLBL.Text = (int.Parse(CompScoreLBL.Text) + 1).ToString();
                PlaySounds(2);
            }
            else if (PicIndex == 1 && ChosenIndex == 2) {
                PlayerScoreLBL.Text = (int.Parse(PlayerScoreLBL.Text) + 1).ToString();
                PlaySounds(1);
            }
            else if (PicIndex == 2 && ChosenIndex == 0) {
                PlayerScoreLBL.Text = (int.Parse(PlayerScoreLBL.Text) + 1).ToString();
                PlaySounds(1);
            }
            else if (PicIndex == 2 && ChosenIndex == 1) {
                CompScoreLBL.Text = (int.Parse(CompScoreLBL.Text) + 1).ToString();
                PlaySounds(2);
            }
            else if (ChosenIndex == 3) {
                CompScoreLBL.Text = (int.Parse(CompScoreLBL.Text) + 1).ToString();
                PlaySounds(2);
            }
            else if (ChosenIndex == PicIndex) clap.Play();
            SetBTN.Enabled = true;
        }

        private void AgainBTN_Click(object sender, EventArgs e) {
            StartAgain();
        }

        private void PlaySounds(int won) {
            if (won == 1) {
                if (int.Parse(PlayerScoreLBL.Text) >= 4) crazyclap.Play();
                else clap.Play(); 
            } else if (won == 2) {
                if (int.Parse(CompScoreLBL.Text) >= 4) laughter.Play();
                else laugh.Play();
            }

        }
    }
}

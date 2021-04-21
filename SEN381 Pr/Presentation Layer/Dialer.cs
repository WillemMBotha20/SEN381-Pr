using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace SEN381_Pr.Presentation_Layer
{
    public partial class Dialer : Form
    {
        CallHandlerFrm call = new CallHandlerFrm();
        static Stream tone = Properties.Resources.Phone_Internal_RingingCalling;
        SoundPlayer Player = new SoundPlayer(tone);
        Stopwatch stopwatch = new Stopwatch();
        TimeSpan Clock = new TimeSpan(00 ,00, 00);
        string ElapsedTime = "";
        

        public Dialer()
        {
            InitializeComponent();
        }

        private void Dialer_Load(object sender, EventArgs e)
        {
            label1.Text = CallHandlerFrm.FirstName;
            label2.Text = CallHandlerFrm.SurName;
            label3.Text = CallHandlerFrm.Number;
            timer1.Interval = 5000;
            timer2.Interval = 1000;
            tone.Position = 0;
            timer1.Start();
            Player.Play();   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Player.Stop();
            (new CallHandlerFrm()).Show();
            this.Hide();
            ElapsedTime = Clock.ToString(@"hh\:mm\:ss");
            MessageBox.Show("Your call duration: " + ElapsedTime);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player.Stop();
            label4.Text = "Connected";
            timer2.Start();
            stopwatch.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Clock = stopwatch.Elapsed;
            label5.Text = Clock.ToString(@"hh\:mm\:ss");
        }
    }
}

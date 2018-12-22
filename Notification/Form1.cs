using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
namespace Notification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Process[] pname = Process.GetProcessesByName("Assistant");
            //if (pname.Length > 0)
            //{
            //    foreach (var process in Process.GetProcessesByName("Assistant"))
            //    {
            //        process.Kill();
            //    }
            //    Process.Start(@"\\192.168.0.1\Software\Assistant\Assistant.exe");

            //}
            //else
            //{
            //    MessageBox.Show("Process Not running");
            //}

            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;

            //this.Hide();
            ////Application.Exit();
            //notifyIcon1.Visible = false;
            //timerCheck.Interval = 1000;

            //int timeinterval2 = Properties.Settings.Default.NotifIntervalEnabledCheck;
            //timerCheck.Interval = timeinterval2;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            int timeinterval =  Properties.Settings.Default.TimerInterval;
            timer.Interval = timeinterval;


            if (Properties.Settings.Default.NotifEnabled == false)

           {
                timerNotif.Enabled = false;

            }
            if (Properties.Settings.Default.NotifEnabled == true)
            {
                timerNotif.Enabled = true;
                int timernotif = Properties.Settings.Default.NotifInterval;
                timerNotif.Interval = timernotif;
            }




        }

        private void timerInterval_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            string NotifTitle = Properties.Settings.Default.NotifTitle;
            string NotifDescription = Properties.Settings.Default.NotifMessage;
            notifyIcon1.ShowBalloonTip(1000, NotifTitle, NotifDescription, ToolTipIcon.Info);
            notifyIcon1.Visible = false;
        }
    }
}

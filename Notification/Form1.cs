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
using System.Configuration;
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

            timer.Interval =Int32.Parse( ConfigurationManager.AppSettings["TimerInterval"]) * 1000 * 60;
            
            timerNotif.Interval = Int32.Parse(ConfigurationManager.AppSettings["NotifInterval"]) * 1000 * 60;

            if ((ModifierKeys & Keys.Shift) != 0)
            {
                NotifSetting form2 = new NotifSetting();
                form2.Show();
            }
            notifyIcon1.Visible = false;


            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            this.Hide();
            
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
            try
            {
               // timer.Interval = Int32.Parse(ConfigurationManager.AppSettings["TimerInterval"]) * 1000 * 60;


                if ((ConfigurationManager.AppSettings["NotifEnabled"]) == "false")

                {
                    timerNotif.Enabled = false;

                }
                if (ConfigurationManager.AppSettings["NotifEnabled"] == "true")
                {
                    timerNotif.Enabled = true;
                    
                    //timerNotif.Interval = Int32.Parse(ConfigurationManager.AppSettings["NotifInterval"]) * 60 * 1000;
                }
            }
            catch
            { }



        }

        private void timerInterval_Tick(object sender, EventArgs e)
        {
            try
              
            {
               // var executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

               // var location = executingAssembly.Location;
               // var Location = @"\\192.168.0.1\Software\Assistant\Notification\Notification.exe.Config";
                //var config = ConfigurationManager.OpenExeConfiguration(Location);

                int timernotif1  = timerNotif.Interval*60*1000;
                
    
                int timernotif =Int32.Parse(ConfigurationManager.AppSettings["NotifInterval"]);

                if (timernotif1!=timernotif )
                {
                    timerNotif.Interval = timernotif * 60 * 1000;
                }
                
                notifyIcon1.Visible = true;
                string NotifTitle = ConfigurationManager.AppSettings["NotifTitle"];
                string NotifDescription = ConfigurationManager.AppSettings["NotifMessage"];
                int timershow =Int32.Parse( ConfigurationManager.AppSettings["NotifTimeToshow"]);
                notifyIcon1.ShowBalloonTip(timershow, NotifTitle, NotifDescription, ToolTipIcon.None);
                notifyIcon1.Visible = false;
                // Force a reload in memory of the changed section.
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch
            { }
        }
    }
}

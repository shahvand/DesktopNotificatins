using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace Notification
{
    public partial class NotifSetting : Form
    {
        

        public NotifSetting()
        {
            InitializeComponent();
        }

        private void NotifSetting_Load(object sender, EventArgs e)
        {
            


            txttimerintervalEnabled.Text = ConfigurationManager.AppSettings["TimerInterval"];
            var result = (ConfigurationManager.AppSettings["NotifEnabled"]) ;
            checkboxNotifEnabled.Checked = Convert.ToBoolean(result) ;
            txtNotfiTtitle.Text = ConfigurationManager.AppSettings["NotifTitle"];
            txtNotifMessage.Text = ConfigurationManager.AppSettings["NotifMessage"];
            txtNotifInterval.Text = ConfigurationManager.AppSettings["NotifInterval"];
            txtNotifTimeShow.Text = ConfigurationManager.AppSettings["NotifTimeToshow"];
           

        }

        private void txttimerintervalEnabled_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           // try
           // {


                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                //config.AppSettings.Settings.Remove("TimerInterval");
                //config.AppSettings.Settings.Remove("NotifEnabled");
                //config.AppSettings.Settings.Remove("NotifTitle");
                //config.AppSettings.Settings.Remove("NotifMessage");
                //config.AppSettings.Settings.Remove("NotifInterval");
                //config.AppSettings.Settings.Remove("NotifTimeToshow");

                config.AppSettings.Settings["TimerInterval"].Value= txttimerintervalEnabled.Text;
                var config2 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                bool result = checkboxNotifEnabled.CheckState == CheckState.Checked ? true : false;

                config2.AppSettings.Settings["NotifEnabled"].Value= result.ToString();
                config2.AppSettings.Settings["NotifTitle"].Value= txtNotfiTtitle.Text;
                config2.AppSettings.Settings["NotifMessage"].Value = txtNotifMessage.Text;
                config2.AppSettings.Settings["NotifInterval"].Value = txtNotifInterval.Text;
                config2.AppSettings.Settings["NotifTimeToshow"].Value = txtNotifTimeShow.Text;

                config2.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                MessageBox.Show("All Content Will Be saved");
                Application.Exit();
                

          //  }
          //  catch
          //  {
                //MessageBox.Show(Exception ,ex);
           // }
        }
    }
}

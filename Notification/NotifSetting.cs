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
            //var PrivateSize = Properties.Settings.Default.PrivateSize;
            //this.chPrivateSize.Checked = PrivateSize;


            txttimerintervalEnabled.Text = ConfigurationManager.AppSettings["TimerInterval"];
            var result = (ConfigurationManager.AppSettings["NotifEnabled"]) ;
            checkboxNotifEnabled.Checked = Convert.ToBoolean(result) ;
            txtNotfiTtitle.Text = ConfigurationManager.AppSettings["NotifTitle"];
            txtNotifMessage.Text = ConfigurationManager.AppSettings["NotifMessage"];
            txtNotifInterval.Text = ConfigurationManager.AppSettings["NotifInterval"];
            txtNotifTimeShow.Text = ConfigurationManager.AppSettings["NotifTimeToshow"];
           // comboIcon.Text = Properties.Settings.Default.NotifIcon.ToString();

        }

        private void txttimerintervalEnabled_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
    //        Properties.Settings.Default.TimerInterval =Int32.Parse( txttimerintervalEnabled.Text);
    //        Properties.Settings.Default.NotifEnabled = checkboxNotifEnabled.Checked;
    //       Properties.Settings.Default.NotifTitle = txtNotfiTtitle.Text;
    //        Properties.Settings.Default.NotifMessage = txtNotifMessage.Text;
    //        Properties.Settings.Default.NotifInterval = Int32.Parse(txtNotifInterval.Text);
    //        Properties.Settings.Default.NotifTimeToshow = Int32.Parse(txtNotifTimeShow.Text);
    
    ////Properties.Settings.Default.NotifIcon = System.Windows.Forms.ToolTipIcon(comboIcon.Text);

    //        Properties.Settings.Default.Save();



            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("TimerInterval");
            config.AppSettings.Settings.Remove("NotifEnabled");
            config.AppSettings.Settings.Remove("NotifTitle");
            config.AppSettings.Settings.Remove("NotifMessage");
            config.AppSettings.Settings.Remove("NotifInterval");
            config.AppSettings.Settings.Remove("NotifTimeToshow");

            config.AppSettings.Settings.Add("TimerInterval",txttimerintervalEnabled.Text);
            bool result = checkboxNotifEnabled.CheckState == CheckState.Checked ? true : false;

            config.AppSettings.Settings.Add("NotifEnabled", result.ToString());
            config.AppSettings.Settings.Add("NotifTitle", txtNotfiTtitle.Text);
            config.AppSettings.Settings.Add("NotifMessage", txtNotifMessage.Text);
            config.AppSettings.Settings.Add("NotifInterval", txtNotifInterval.Text);
            config.AppSettings.Settings.Add("NotifTimeToshow", txtNotifTimeShow.Text);
           
            config.Save(ConfigurationSaveMode.Minimal);
        }
    }
}

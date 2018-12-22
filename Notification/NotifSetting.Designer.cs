namespace Notification
{
    partial class NotifSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNotfiTtitle = new System.Windows.Forms.TextBox();
            this.txtNotifMessage = new System.Windows.Forms.TextBox();
            this.checkboxNotifEnabled = new System.Windows.Forms.CheckBox();
            this.txttimerintervalEnabled = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotifInterval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotifTimeShow = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNotfiTtitle
            // 
            this.txtNotfiTtitle.Location = new System.Drawing.Point(522, 157);
            this.txtNotfiTtitle.Name = "txtNotfiTtitle";
            this.txtNotfiTtitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotfiTtitle.Size = new System.Drawing.Size(121, 20);
            this.txtNotfiTtitle.TabIndex = 2;
            // 
            // txtNotifMessage
            // 
            this.txtNotifMessage.Location = new System.Drawing.Point(146, 193);
            this.txtNotifMessage.Name = "txtNotifMessage";
            this.txtNotifMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotifMessage.Size = new System.Drawing.Size(497, 20);
            this.txtNotifMessage.TabIndex = 3;
            // 
            // checkboxNotifEnabled
            // 
            this.checkboxNotifEnabled.AutoSize = true;
            this.checkboxNotifEnabled.Location = new System.Drawing.Point(631, 126);
            this.checkboxNotifEnabled.Name = "checkboxNotifEnabled";
            this.checkboxNotifEnabled.Size = new System.Drawing.Size(100, 17);
            this.checkboxNotifEnabled.TabIndex = 4;
            this.checkboxNotifEnabled.Text = "فعال سازی پیام";
            this.checkboxNotifEnabled.UseVisualStyleBackColor = true;
            // 
            // txttimerintervalEnabled
            // 
            this.txttimerintervalEnabled.Location = new System.Drawing.Point(543, 27);
            this.txttimerintervalEnabled.Name = "txttimerintervalEnabled";
            this.txttimerintervalEnabled.Size = new System.Drawing.Size(100, 20);
            this.txttimerintervalEnabled.TabIndex = 5;
            this.txttimerintervalEnabled.TextChanged += new System.EventHandler(this.txttimerintervalEnabled_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "عنوان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "پیام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "تایمر چک کردن تنظیمات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "اینتروال نمایش پیام";
            // 
            // txtNotifInterval
            // 
            this.txtNotifInterval.Location = new System.Drawing.Point(543, 233);
            this.txtNotifInterval.Name = "txtNotifInterval";
            this.txtNotifInterval.Size = new System.Drawing.Size(100, 20);
            this.txtNotifInterval.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "مدت زمان ماندن پیام";
            // 
            // txtNotifTimeShow
            // 
            this.txtNotifTimeShow.Location = new System.Drawing.Point(543, 273);
            this.txtNotifTimeShow.Name = "txtNotifTimeShow";
            this.txtNotifTimeShow.Size = new System.Drawing.Size(100, 20);
            this.txtNotifTimeShow.TabIndex = 11;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(30, 376);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "دقیقه";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "دقیقه";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "میلی ثانیه";
            // 
            // NotifSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotifTimeShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotifInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimerintervalEnabled);
            this.Controls.Add(this.checkboxNotifEnabled);
            this.Controls.Add(this.txtNotifMessage);
            this.Controls.Add(this.txtNotfiTtitle);
            this.Name = "NotifSetting";
            this.Text = "NotifSetting";
            this.Load += new System.EventHandler(this.NotifSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNotfiTtitle;
        private System.Windows.Forms.TextBox txtNotifMessage;
        private System.Windows.Forms.CheckBox checkboxNotifEnabled;
        private System.Windows.Forms.TextBox txttimerintervalEnabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotifInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotifTimeShow;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
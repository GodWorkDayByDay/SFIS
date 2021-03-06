﻿namespace SFIS_V2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bt_exit = new DevComponents.DotNetBar.ButtonX();
            this.bt_login = new DevComponents.DotNetBar.ButtonX();
            this.tb_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.bt_CfgIp = new DevComponents.DotNetBar.ButtonX();
            this.imbtInitwebser = new DevComponents.DotNetBar.ButtonItem();
            this.lb_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_exit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_exit.Location = new System.Drawing.Point(109, 173);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(55, 23);
            this.bt_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_exit.TabIndex = 4;
            this.bt_exit.Text = "退出 &Q";
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_login
            // 
            this.bt_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_login.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_login.Location = new System.Drawing.Point(191, 173);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(59, 23);
            this.bt_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "登录 &E";
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_password
            // 
            // 
            // 
            // 
            this.tb_password.Border.Class = "TextBoxBorder";
            this.tb_password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.Location = new System.Drawing.Point(67, 132);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(183, 26);
            this.tb_password.TabIndex = 2;
            this.tb_password.Tag = "1";
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // tb_username
            // 
            // 
            // 
            // 
            this.tb_username.Border.Class = "TextBoxBorder";
            this.tb_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_username.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_username.Location = new System.Drawing.Point(67, 94);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(183, 26);
            this.tb_username.TabIndex = 0;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_username_KeyDown);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(11, 135);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "[密 码:]";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Image = ((System.Drawing.Image)(resources.GetObject("labelX2.Image")));
            this.labelX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.labelX2.Location = new System.Drawing.Point(18, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(243, 62);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "用 户 登 录";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX2.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(11, 97);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "[账 户:]";
            // 
            // bt_CfgIp
            // 
            this.bt_CfgIp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_CfgIp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_CfgIp.Location = new System.Drawing.Point(32, 173);
            this.bt_CfgIp.Name = "bt_CfgIp";
            this.bt_CfgIp.Size = new System.Drawing.Size(56, 23);
            this.bt_CfgIp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_CfgIp.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.imbtInitwebser});
            this.bt_CfgIp.TabIndex = 13;
            this.bt_CfgIp.Text = "设置";
            this.bt_CfgIp.Click += new System.EventHandler(this.bt_CfgIp_Click);
            // 
            // imbtInitwebser
            // 
            this.imbtInitwebser.GlobalItem = false;
            this.imbtInitwebser.Name = "imbtInitwebser";
            this.imbtInitwebser.Text = "修复WEB服务";
            this.imbtInitwebser.Click += new System.EventHandler(this.imbtInitwebser_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.Location = new System.Drawing.Point(12, 200);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(252, 28);
            this.lb_msg.TabIndex = 14;
            this.lb_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 232);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.bt_CfgIp);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX bt_exit;
        private DevComponents.DotNetBar.ButtonX bt_login;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_username;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX bt_CfgIp;
        public DevComponents.DotNetBar.Controls.TextBoxX tb_password;
        private System.Windows.Forms.Label lb_msg;
        private DevComponents.DotNetBar.ButtonItem imbtInitwebser;
    }
}
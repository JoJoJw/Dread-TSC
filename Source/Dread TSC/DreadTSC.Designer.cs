namespace Dread_TSC
{
    partial class DreadTSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DreadTSC));
            this.logo = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.Panel();
            this.bannerlabel = new System.Windows.Forms.Label();
            this.createBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.rightborder = new System.Windows.Forms.Panel();
            this.leftborder = new System.Windows.Forms.Panel();
            this.bottomborder = new System.Windows.Forms.Panel();
            this.WebHookTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.banner.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::Dread_TSC.Properties.Resources.Untitled;
            this.logo.Location = new System.Drawing.Point(148, 46);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(133, 126);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.banner.Controls.Add(this.bannerlabel);
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(429, 35);
            this.banner.TabIndex = 1;
            // 
            // bannerlabel
            // 
            this.bannerlabel.AutoSize = true;
            this.bannerlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerlabel.ForeColor = System.Drawing.Color.Red;
            this.bannerlabel.Location = new System.Drawing.Point(177, 9);
            this.bannerlabel.Name = "bannerlabel";
            this.bannerlabel.Size = new System.Drawing.Size(80, 20);
            this.bannerlabel.TabIndex = 2;
            this.bannerlabel.Text = "Dread TSC";
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.Transparent;
            this.createBtn.CheckedState.Parent = this.createBtn;
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.CustomImages.Parent = this.createBtn;
            this.createBtn.FillColor = System.Drawing.Color.Red;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.HoveredState.Parent = this.createBtn;
            this.createBtn.Location = new System.Drawing.Point(12, 243);
            this.createBtn.Name = "createBtn";
            this.createBtn.PressedColor = System.Drawing.Color.White;
            this.createBtn.PressedDepth = 50;
            this.createBtn.ShadowDecoration.Parent = this.createBtn;
            this.createBtn.Size = new System.Drawing.Size(405, 39);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Create";
            this.createBtn.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // rightborder
            // 
            this.rightborder.BackColor = System.Drawing.Color.Red;
            this.rightborder.Location = new System.Drawing.Point(425, -6);
            this.rightborder.Name = "rightborder";
            this.rightborder.Size = new System.Drawing.Size(4, 308);
            this.rightborder.TabIndex = 4;
            // 
            // leftborder
            // 
            this.leftborder.BackColor = System.Drawing.Color.Red;
            this.leftborder.Location = new System.Drawing.Point(0, -3);
            this.leftborder.Name = "leftborder";
            this.leftborder.Size = new System.Drawing.Size(4, 308);
            this.leftborder.TabIndex = 5;
            // 
            // bottomborder
            // 
            this.bottomborder.BackColor = System.Drawing.Color.Red;
            this.bottomborder.Location = new System.Drawing.Point(3, 298);
            this.bottomborder.Name = "bottomborder";
            this.bottomborder.Size = new System.Drawing.Size(427, 4);
            this.bottomborder.TabIndex = 6;
            // 
            // WebHookTxt
            // 
            this.WebHookTxt.Animated = true;
            this.WebHookTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WebHookTxt.DefaultText = "";
            this.WebHookTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.WebHookTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.WebHookTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WebHookTxt.DisabledState.Parent = this.WebHookTxt;
            this.WebHookTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WebHookTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.WebHookTxt.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.WebHookTxt.FocusedState.Parent = this.WebHookTxt;
            this.WebHookTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WebHookTxt.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.WebHookTxt.HoverState.Parent = this.WebHookTxt;
            this.WebHookTxt.Location = new System.Drawing.Point(10, 189);
            this.WebHookTxt.Name = "WebHookTxt";
            this.WebHookTxt.PasswordChar = '\0';
            this.WebHookTxt.PlaceholderText = "Webhook";
            this.WebHookTxt.SelectedText = "";
            this.WebHookTxt.ShadowDecoration.Parent = this.WebHookTxt;
            this.WebHookTxt.Size = new System.Drawing.Size(407, 36);
            this.WebHookTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.WebHookTxt.TabIndex = 7;
            this.WebHookTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.bannerlabel;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.banner;
            // 
            // DreadTSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(429, 302);
            this.Controls.Add(this.WebHookTxt);
            this.Controls.Add(this.bottomborder);
            this.Controls.Add(this.leftborder);
            this.Controls.Add(this.rightborder);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DreadTSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dread TSC";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.banner.ResumeLayout(false);
            this.banner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel banner;
        private System.Windows.Forms.Label bannerlabel;
        private Siticone.UI.WinForms.SiticoneButton createBtn;
        private System.Windows.Forms.Panel rightborder;
        private System.Windows.Forms.Panel leftborder;
        private System.Windows.Forms.Panel bottomborder;
        private Guna.UI2.WinForms.Guna2TextBox WebHookTxt;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}


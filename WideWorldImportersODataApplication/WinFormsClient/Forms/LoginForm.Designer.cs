namespace WinFormsClient.Forms
{
    partial class LoginForm
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbResult = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogIn = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(76, 46);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(166, 20);
            this.tbPassword.TabIndex = 40;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(76, 8);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(166, 20);
            this.tbName.TabIndex = 39;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(15, 48);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 38;
            this.lbPassword.Text = "Password";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(34, 10);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 37;
            this.lbName.Text = "Name";
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(346, 162);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 44;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 89);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(408, 22);
            this.statusStrip.TabIndex = 43;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(267, 45);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(79, 20);
            this.btExit.TabIndex = 42;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(267, 5);
            this.btLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(79, 20);
            this.btLogIn.TabIndex = 41;
            this.btLogIn.Text = "Sign In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 111);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogIn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ToolStripStatusLabel errorLabel;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogIn;
    }
}
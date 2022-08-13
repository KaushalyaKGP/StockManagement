
namespace StockManagement
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
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.logInPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.logInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::StockManagement.Properties.Resources.login_icon_button_vector_illustration_isolated_white_background_127000574;
            this.loginPictureBox.Location = new System.Drawing.Point(26, 100);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(242, 219);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPictureBox.TabIndex = 0;
            this.loginPictureBox.TabStop = false;
            // 
            // logInPanel
            // 
            this.logInPanel.Controls.Add(this.loginButton);
            this.logInPanel.Controls.Add(this.loginUsernameTextBox);
            this.logInPanel.Controls.Add(this.loginPasswordTextBox);
            this.logInPanel.Controls.Add(this.loginUsernameLabel);
            this.logInPanel.Controls.Add(this.loginPasswordLabel);
            this.logInPanel.Location = new System.Drawing.Point(274, 100);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(465, 219);
            this.logInPanel.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.loginButton.Location = new System.Drawing.Point(331, 160);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(105, 43);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.loginUsernameTextBox.Location = new System.Drawing.Point(203, 42);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(233, 26);
            this.loginUsernameTextBox.TabIndex = 6;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.loginPasswordTextBox.Location = new System.Drawing.Point(203, 116);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(233, 26);
            this.loginPasswordTextBox.TabIndex = 2;
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.loginUsernameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginUsernameLabel.Location = new System.Drawing.Point(22, 42);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(157, 20);
            this.loginUsernameLabel.TabIndex = 5;
            this.loginUsernameLabel.Text = "Enter Username :";
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.loginPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginPasswordLabel.Location = new System.Drawing.Point(22, 118);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(154, 20);
            this.loginPasswordLabel.TabIndex = 4;
            this.loginPasswordLabel.Text = "Enter Password :";
            // 
            // loginTitleLabel
            // 
            this.loginTitleLabel.AutoSize = true;
            this.loginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.loginTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginTitleLabel.Location = new System.Drawing.Point(238, 19);
            this.loginTitleLabel.Name = "loginTitleLabel";
            this.loginTitleLabel.Size = new System.Drawing.Size(289, 58);
            this.loginTitleLabel.TabIndex = 6;
            this.loginTitleLabel.Text = "Login Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(764, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginTitleLabel);
            this.Controls.Add(this.logInPanel);
            this.Controls.Add(this.loginPictureBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.Panel logInPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.Label loginTitleLabel;
        private System.Windows.Forms.Button button1;
    }
}


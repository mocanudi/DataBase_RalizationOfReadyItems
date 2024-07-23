
namespace KURS.Forms
{
    partial class Enter
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
            this.Enter_label = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.EnterLogin_Label = new System.Windows.Forms.Label();
            this.EnterPassword_Label = new System.Windows.Forms.Label();
            this.Registration_linkLabel = new System.Windows.Forms.LinkLabel();
            this.ShowPassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ToEnter_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Enter_label
            // 
            this.Enter_label.AutoSize = true;
            this.Enter_label.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter_label.Location = new System.Drawing.Point(175, 28);
            this.Enter_label.Name = "Enter_label";
            this.Enter_label.Size = new System.Drawing.Size(68, 29);
            this.Enter_label.TabIndex = 0;
            this.Enter_label.Text = "Вход\r\n";
            this.Enter_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close.ForeColor = System.Drawing.Color.AliceBlue;
            this.Close.Location = new System.Drawing.Point(395, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // EnterLogin_Label
            // 
            this.EnterLogin_Label.AutoSize = true;
            this.EnterLogin_Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterLogin_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterLogin_Label.Location = new System.Drawing.Point(29, 84);
            this.EnterLogin_Label.Name = "EnterLogin_Label";
            this.EnterLogin_Label.Size = new System.Drawing.Size(105, 18);
            this.EnterLogin_Label.TabIndex = 2;
            this.EnterLogin_Label.Text = "Введите логин";
            this.EnterLogin_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // EnterPassword_Label
            // 
            this.EnterPassword_Label.AutoSize = true;
            this.EnterPassword_Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPassword_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterPassword_Label.Location = new System.Drawing.Point(29, 160);
            this.EnterPassword_Label.Name = "EnterPassword_Label";
            this.EnterPassword_Label.Size = new System.Drawing.Size(115, 18);
            this.EnterPassword_Label.TabIndex = 3;
            this.EnterPassword_Label.Text = "Введите пароль";
            this.EnterPassword_Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Registration_linkLabel
            // 
            this.Registration_linkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(113)))), ((int)(((byte)(63)))));
            this.Registration_linkLabel.AutoSize = true;
            this.Registration_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.Registration_linkLabel.Location = new System.Drawing.Point(165, 336);
            this.Registration_linkLabel.Name = "Registration_linkLabel";
            this.Registration_linkLabel.Size = new System.Drawing.Size(92, 16);
            this.Registration_linkLabel.TabIndex = 4;
            this.Registration_linkLabel.TabStop = true;
            this.Registration_linkLabel.Text = "Регистрация";
            this.Registration_linkLabel.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.Registration_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ShowPassword_CheckBox
            // 
            this.ShowPassword_CheckBox.AutoSize = true;
            this.ShowPassword_CheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowPassword_CheckBox.Location = new System.Drawing.Point(282, 216);
            this.ShowPassword_CheckBox.Name = "ShowPassword_CheckBox";
            this.ShowPassword_CheckBox.Size = new System.Drawing.Size(114, 17);
            this.ShowPassword_CheckBox.TabIndex = 5;
            this.ShowPassword_CheckBox.Text = "Показать пароль";
            this.ShowPassword_CheckBox.UseVisualStyleBackColor = true;
            this.ShowPassword_CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Location = new System.Drawing.Point(32, 105);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(364, 20);
            this.Login.TabIndex = 6;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Location = new System.Drawing.Point(32, 181);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(364, 20);
            this.Password.TabIndex = 7;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // ToEnter_button
            // 
            this.ToEnter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.ToEnter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToEnter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToEnter_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToEnter_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToEnter_button.Location = new System.Drawing.Point(32, 264);
            this.ToEnter_button.Name = "ToEnter_button";
            this.ToEnter_button.Size = new System.Drawing.Size(364, 57);
            this.ToEnter_button.TabIndex = 8;
            this.ToEnter_button.Text = "Войти";
            this.ToEnter_button.UseVisualStyleBackColor = false;
            this.ToEnter_button.Click += new System.EventHandler(this.ToEnter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(32, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 3);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.panel2.Location = new System.Drawing.Point(32, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 3);
            this.panel2.TabIndex = 9;
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(430, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToEnter_button);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.ShowPassword_CheckBox);
            this.Controls.Add(this.Registration_linkLabel);
            this.Controls.Add(this.EnterPassword_Label);
            this.Controls.Add(this.EnterLogin_Label);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Enter_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Enter";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enter_label;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label EnterLogin_Label;
        private System.Windows.Forms.Label EnterPassword_Label;
        private System.Windows.Forms.LinkLabel Registration_linkLabel;
        private System.Windows.Forms.CheckBox ShowPassword_CheckBox;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ToEnter_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
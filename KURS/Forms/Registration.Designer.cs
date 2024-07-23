
namespace KURS.Forms
{
    partial class Registration
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToEnter_button = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.ShowPassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.Enter_linkLabel = new System.Windows.Forms.LinkLabel();
            this.EnterPassword_Label = new System.Windows.Forms.Label();
            this.EnterLogin_Label = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Registration_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.panel2.Location = new System.Drawing.Point(32, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 3);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(31, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 3);
            this.panel1.TabIndex = 20;
            // 
            // ToEnter_button
            // 
            this.ToEnter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.ToEnter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToEnter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToEnter_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToEnter_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToEnter_button.Location = new System.Drawing.Point(32, 265);
            this.ToEnter_button.Name = "ToEnter_button";
            this.ToEnter_button.Size = new System.Drawing.Size(364, 57);
            this.ToEnter_button.TabIndex = 18;
            this.ToEnter_button.Text = "Зарегистрироваться";
            this.ToEnter_button.UseVisualStyleBackColor = false;
            this.ToEnter_button.Click += new System.EventHandler(this.ToEnter_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Location = new System.Drawing.Point(31, 183);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(364, 20);
            this.Password.TabIndex = 17;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Location = new System.Drawing.Point(31, 105);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(364, 20);
            this.Login.TabIndex = 16;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // ShowPassword_CheckBox
            // 
            this.ShowPassword_CheckBox.AutoSize = true;
            this.ShowPassword_CheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowPassword_CheckBox.Location = new System.Drawing.Point(281, 218);
            this.ShowPassword_CheckBox.Name = "ShowPassword_CheckBox";
            this.ShowPassword_CheckBox.Size = new System.Drawing.Size(114, 17);
            this.ShowPassword_CheckBox.TabIndex = 15;
            this.ShowPassword_CheckBox.Text = "Показать пароль";
            this.ShowPassword_CheckBox.UseVisualStyleBackColor = true;
            this.ShowPassword_CheckBox.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckBox_CheckedChanged);
            // 
            // Enter_linkLabel
            // 
            this.Enter_linkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(113)))), ((int)(((byte)(63)))));
            this.Enter_linkLabel.AutoSize = true;
            this.Enter_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(206)))), ((int)(((byte)(85)))));
            this.Enter_linkLabel.Location = new System.Drawing.Point(187, 340);
            this.Enter_linkLabel.Name = "Enter_linkLabel";
            this.Enter_linkLabel.Size = new System.Drawing.Size(39, 16);
            this.Enter_linkLabel.TabIndex = 14;
            this.Enter_linkLabel.TabStop = true;
            this.Enter_linkLabel.Text = "Вход";
            this.Enter_linkLabel.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.Enter_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Enter_linkLabel_LinkClicked);
            // 
            // EnterPassword_Label
            // 
            this.EnterPassword_Label.AutoSize = true;
            this.EnterPassword_Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPassword_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterPassword_Label.Location = new System.Drawing.Point(29, 162);
            this.EnterPassword_Label.Name = "EnterPassword_Label";
            this.EnterPassword_Label.Size = new System.Drawing.Size(115, 18);
            this.EnterPassword_Label.TabIndex = 13;
            this.EnterPassword_Label.Text = "Введите пароль";
            this.EnterPassword_Label.Click += new System.EventHandler(this.EnterPassword_Label_Click);
            // 
            // EnterLogin_Label
            // 
            this.EnterLogin_Label.AutoSize = true;
            this.EnterLogin_Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterLogin_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterLogin_Label.Location = new System.Drawing.Point(29, 84);
            this.EnterLogin_Label.Name = "EnterLogin_Label";
            this.EnterLogin_Label.Size = new System.Drawing.Size(105, 18);
            this.EnterLogin_Label.TabIndex = 12;
            this.EnterLogin_Label.Text = "Введите логин";
            this.EnterLogin_Label.Click += new System.EventHandler(this.EnterLogin_Label_Click);
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
            this.Close.TabIndex = 11;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Registration_label
            // 
            this.Registration_label.AutoSize = true;
            this.Registration_label.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registration_label.Location = new System.Drawing.Point(127, 29);
            this.Registration_label.Name = "Registration_label";
            this.Registration_label.Size = new System.Drawing.Size(164, 29);
            this.Registration_label.TabIndex = 10;
            this.Registration_label.Text = "Регистрация";
            // 
            // Registration
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
            this.Controls.Add(this.Enter_linkLabel);
            this.Controls.Add(this.EnterPassword_Label);
            this.Controls.Add(this.EnterLogin_Label);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Registration_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ToEnter_button;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.CheckBox ShowPassword_CheckBox;
        private System.Windows.Forms.LinkLabel Enter_linkLabel;
        private System.Windows.Forms.Label EnterPassword_Label;
        private System.Windows.Forms.Label EnterLogin_Label;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Registration_label;
    }
}
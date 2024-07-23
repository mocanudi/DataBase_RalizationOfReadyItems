
namespace KURS.Forms
{
    partial class Forma
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
            this.Close = new System.Windows.Forms.Button();
            this.Enter_label = new System.Windows.Forms.Label();
            this.Clients_btn = new System.Windows.Forms.Button();
            this.Items_btn = new System.Windows.Forms.Button();
            this.Orders_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Silver;
            this.Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close.ForeColor = System.Drawing.Color.AliceBlue;
            this.Close.Location = new System.Drawing.Point(1080, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 2;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Enter_label
            // 
            this.Enter_label.AutoSize = true;
            this.Enter_label.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enter_label.Location = new System.Drawing.Point(52, 34);
            this.Enter_label.Name = "Enter_label";
            this.Enter_label.Size = new System.Drawing.Size(118, 29);
            this.Enter_label.TabIndex = 3;
            this.Enter_label.Text = "Таблицы";
            this.Enter_label.Click += new System.EventHandler(this.Enter_label_Click);
            // 
            // Clients_btn
            // 
            this.Clients_btn.BackColor = System.Drawing.Color.Silver;
            this.Clients_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clients_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clients_btn.Location = new System.Drawing.Point(31, 19);
            this.Clients_btn.Name = "Clients_btn";
            this.Clients_btn.Size = new System.Drawing.Size(211, 60);
            this.Clients_btn.TabIndex = 4;
            this.Clients_btn.Text = "Покупатели";
            this.Clients_btn.UseVisualStyleBackColor = false;
            this.Clients_btn.Click += new System.EventHandler(this.Clients_btn_Click);
            // 
            // Items_btn
            // 
            this.Items_btn.BackColor = System.Drawing.Color.Silver;
            this.Items_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Items_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Items_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Items_btn.Location = new System.Drawing.Point(271, 19);
            this.Items_btn.Name = "Items_btn";
            this.Items_btn.Size = new System.Drawing.Size(209, 60);
            this.Items_btn.TabIndex = 5;
            this.Items_btn.Text = "Товары";
            this.Items_btn.UseVisualStyleBackColor = false;
            this.Items_btn.Click += new System.EventHandler(this.Items_btn_Click);
            // 
            // Orders_btn
            // 
            this.Orders_btn.BackColor = System.Drawing.Color.Silver;
            this.Orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Orders_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orders_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Orders_btn.Location = new System.Drawing.Point(512, 19);
            this.Orders_btn.Name = "Orders_btn";
            this.Orders_btn.Size = new System.Drawing.Size(207, 60);
            this.Orders_btn.TabIndex = 6;
            this.Orders_btn.Text = "Заказы";
            this.Orders_btn.UseVisualStyleBackColor = false;
            this.Orders_btn.Click += new System.EventHandler(this.Orders_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Clients_btn);
            this.panel1.Controls.Add(this.Items_btn);
            this.panel1.Controls.Add(this.Orders_btn);
            this.panel1.Location = new System.Drawing.Point(45, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 109);
            this.panel1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(751, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "Доставка";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(434, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Найти запрос";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(57, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Запросы";
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Enter_label);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forma";
            this.Text = "Forma";
            this.Load += new System.EventHandler(this.Forma_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Enter_label;
        private System.Windows.Forms.Button Clients_btn;
        private System.Windows.Forms.Button Items_btn;
        private System.Windows.Forms.Button Orders_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
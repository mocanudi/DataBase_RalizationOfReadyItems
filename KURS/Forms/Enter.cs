using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KURS.Classes;

namespace KURS.Forms
{   
    public partial class Enter : Form
    {
        DataBase database = new DataBase(); 

        public Enter()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if( ShowPassword_CheckBox.Checked)
                Password.UseSystemPasswordChar = true;
            else
                Password.UseSystemPasswordChar = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration frm_reg = new Registration();
            frm_reg.Show();
            this.Hide();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void ToEnter_Click(object sender, EventArgs e)
        {
            var loginUser = Login.Text;
            var passUser = Password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID_authorization, clientAutho_Login, clientAutho_Password from ClientAuthorization where clientAutho_Login = '{loginUser}' and clientAutho_Password = '{passUser}' ";

            SqlCommand command = new SqlCommand(querystring, database.getConnection()); 

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Forma frm = new Forma();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунт не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            this.Password.ForeColor = System.Drawing.Color.White;

        }

        private void Enter_Load(object sender, EventArgs e)
        {
            Password.PasswordChar = '•';
            Password.MaxLength = 50;
            Login.MaxLength = 50;

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            this.Login.ForeColor = System.Drawing.Color.White;

        }
    }
}

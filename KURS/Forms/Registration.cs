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
    public partial class Registration : Form
    {
        DataBase database = new DataBase();

        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ToEnter_Click(object sender, EventArgs e)
        {
            var loginUser = Login.Text;
            var passUser = Password.Text;

            string querystring = $"insert into ClientAuthorization(clientAutho_Login, clientAutho_Password) values ('{loginUser}', '{passUser}')";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            if (command.ExecuteNonQuery() == 1) {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enter frm = new Enter();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Аккаунт не создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            database.ClosedConnection();
        }


        private Boolean checkuser() {
            var loginUser = Login.Text;
            var passUser = Password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID_authorization, clientAutho_Login, clientAutho_Password from ClientAuthorization where clientAutho_Login = '{loginUser}' and clientAutho_Password = '{passUser}' ";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;
        }

        private void ShowPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_CheckBox.Checked)
                Password.UseSystemPasswordChar = true;
            else
                Password.UseSystemPasswordChar = false;
        }

        private void EnterPassword_Label_Click(object sender, EventArgs e)
        {

        }

        private void EnterLogin_Label_Click(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            this.Login.ForeColor = System.Drawing.Color.White;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Enter_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Enter frm_reg = new Enter();
            frm_reg.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Password.PasswordChar = '•';
            Password.MaxLength = 50;
            Login.MaxLength = 50;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            this.Password.ForeColor = System.Drawing.Color.White;
        }
    }
}

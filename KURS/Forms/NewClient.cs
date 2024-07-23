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
    public partial class NewClient : Form
    {
        DataBase database = new DataBase();
        public NewClient()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Clients item = new Clients();
            item.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=test_bd;Integrated Security=True");
            database.OpenConnection();
            con.Open();
            
            int id;


            
            SqlCommand taskInsertCategory = new SqlCommand("Insert into AdressOfClient(clientAdress_Region, clientAdress_City, " +
                "clientAdress_District, clientAdress_Street, clientAdress_House, clientAdress_Appartment) Values(@a, @b, @c, @d, @e, @f)", con);
            taskInsertCategory.Parameters.Add("@a", SqlDbType.VarChar);
            taskInsertCategory.Parameters.Add("@b", SqlDbType.VarChar);
            taskInsertCategory.Parameters.Add("@c", SqlDbType.VarChar);
            taskInsertCategory.Parameters.Add("@d", SqlDbType.VarChar);
            taskInsertCategory.Parameters.Add("@e", SqlDbType.VarChar);
            taskInsertCategory.Parameters.Add("@f", SqlDbType.VarChar);

            taskInsertCategory.Parameters["@a"].Value = textBox6.Text;
            taskInsertCategory.Parameters["@b"].Value = textBox7.Text;
            taskInsertCategory.Parameters["@c"].Value = textBox8.Text;
            taskInsertCategory.Parameters["@d"].Value = textBox9.Text;
            taskInsertCategory.Parameters["@e"].Value = textBox10.Text;
            taskInsertCategory.Parameters["@f"].Value = textBox11.Text;
            taskInsertCategory.ExecuteNonQuery();
           

            SqlDataReader dr;
            DataTable dt = new DataTable();
            SqlCommand task;
            task = new SqlCommand("SELECT TOP 1 ID_AdressOfClient FROM AdressOfClient ORDER BY ID_AdressOfClient DESC", con);
            dr = task.ExecuteReader();
            dt.Load(dr);
            id = (int)dt.Rows[0].ItemArray[0];
            

            SqlCommand taskInsertCar = new SqlCommand("Insert into Client(client_Name, client_Surname, client_Otchestvo, client_Phone, client_Email, ID_AdressOfClient) Values(@a, @b, @c, @d, @e, @f)", con);
            taskInsertCar.Parameters.Add("@a", SqlDbType.VarChar);
            taskInsertCar.Parameters.Add("@b", SqlDbType.VarChar);
            taskInsertCar.Parameters.Add("@c", SqlDbType.VarChar);
            taskInsertCar.Parameters.Add("@d", SqlDbType.VarChar);
            taskInsertCar.Parameters.Add("@e", SqlDbType.VarChar);
            taskInsertCar.Parameters.Add("@f", SqlDbType.Int);

            taskInsertCar.Parameters["@a"].Value = textBox1.Text;
            taskInsertCar.Parameters["@b"].Value = textBox2.Text;
            taskInsertCar.Parameters["@c"].Value = textBox3.Text;
            taskInsertCar.Parameters["@d"].Value = textBox4.Text;
            taskInsertCar.Parameters["@e"].Value = textBox5.Text;
            taskInsertCar.Parameters["@f"].Value = id;
            taskInsertCar.ExecuteNonQuery();

            MessageBox.Show("Клиент добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            database.ClosedConnection();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

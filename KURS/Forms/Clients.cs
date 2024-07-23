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
    public partial class Clients : Form
    {
        DataBase database = new DataBase();

        int selectedRow;
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }

        public Clients()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_client", "ID Клиента");//0
            dataGridView1.Columns.Add("client_Name", "Имя");//1
            dataGridView1.Columns.Add("client_Surname", "Фамилия");//2
            dataGridView1.Columns.Add("client_Otchestvo", "Отчество");//3
            dataGridView1.Columns.Add("client_Phone", "Телефон");//4
            dataGridView1.Columns.Add("client_Email", "Почта");//5
            dataGridView1.Columns.Add("ID_AdressOfClient", "ID Адреса");//6
            dataGridView1.Columns.Add("ID_AdressOfClient", "ID Адреса");//7
            dataGridView1.Columns.Add("clientAdress_Region", "Регион");//8
            dataGridView1.Columns.Add("clientAdress_City", "Город");//9
            dataGridView1.Columns.Add("clientAdress_District", "Район");//10
            dataGridView1.Columns.Add("clientAdress_Street", "Улица");//11
            dataGridView1.Columns.Add("clientAdress_House", "Дом");//12
            dataGridView1.Columns.Add("clientAdress_Appartment", "Квартира");//13
            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
           dwg.Rows.Add(record.GetInt32(0), 
                record.GetString(1), record.GetString(2),
                record.GetString(3), record.GetString(4), 
                record.GetString(5), 
                
                record.GetInt32(6), record.GetInt32(7), 
                record.GetString(8),  record.GetString(9), 
                record.GetString(10), record.GetString(11), 
                record.GetString(12), record.GetString(13),
                RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT * FROM Client INNER JOIN AdressOfClient ON Client.ID_AdressOfClient = AdressOfClient.ID_AdressOfClient";
            
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void Enter_label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reboot_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                string region = row.Cells[8].Value.ToString();
                string city = row.Cells[9].Value.ToString();
                string district = row.Cells[10].Value.ToString();
                string street = row.Cells[12].Value.ToString();
                string house = row.Cells[12].Value.ToString();
                string appartment = row.Cells[13].Value.ToString();

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = string.Format($"({region}, {city}, {district}, {street}, {house}, {appartment})");
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox7.Text = row.Cells[5].Value.ToString();

            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();
            string searchString = $"SELECT * FROM Client" +
                $" where concat (ID_client, client_Name, client_Surname, client_Otchestvo, " +
                $"client_Phone, client_Email) " +
                $"like '%" + Search_tb.Text + "%'";

            string searchString1 = $"SELECT * FROM AdressOfClient" +
                $" where concat (clientAdress_Region, clientAdress_City, clientAdress_District, clientAdress_Street, " +
                $"clientAdress_House, clientAdress_Appartment) " +
                $"like '%" + Search_tb.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());
            SqlCommand command1 = new SqlCommand(searchString1, database.getConnection());
            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }

            reader.Close();
        }

        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewClient additem = new NewClient();
            additem.Show();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[14].Value = RowState.Deleted;
            }
        }

        private new void Update()
        {
            database.OpenConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[14].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"delete from Client where id = '{id}'";

                    var command = new SqlCommand(deleteQuerry, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=test_bd;Integrated Security=True");
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var otch = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var tel = dataGridView1.Rows[index].Cells[4].Value.ToString(); 
                    var email = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var Id_adess = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    string region = dataGridView1.Rows[index].Cells[8].Value.ToString();
                    string city = dataGridView1.Rows[index].Cells[9].Value.ToString();
                    string district = dataGridView1.Rows[index].Cells[10].Value.ToString();
                    string street = dataGridView1.Rows[index].Cells[11].Value.ToString();
                    string house = dataGridView1.Rows[index].Cells[12].Value.ToString();
                    string appartment = dataGridView1.Rows[index].Cells[13].Value.ToString();

                    con.Open();
                    
                    var changeQuerry21 = $"update Client set client_Name = '{name}', client_Surname = '{surname}', client_Otchestvo = '{otch}', " +
                        $"client_Phone = '{tel}', client_Email = '{email}' where ID_client = '{id}'";
                    var changeQuerry23 = $"update AdressOfClient set clientAdress_Region = '{region}', clientAdress_City = '{city}', clientAdress_District = '{district}', " +
                        $"clientAdress_Street = '{street}', clientAdress_House = '{house}', clientAdress_Appartment = '{appartment}'" +
                        $"where ID_AdressOfClient = '{id}'";


                    var changeQuerry1 = new SqlCommand("update AdressOfClient set clientAdress_Region = @a, clientAdress_City = @b, " +
                        "clientAdress_District = @c, " +
                        $"clientAdress_Street = @d, clientAdress_House = @e, clientAdress_Appartment = @f where ID_AdressOfClient = '{id}'", con);
                   

                    changeQuerry1.Parameters["@a"].Value = textBox5.Text.Split()[0];
                    changeQuerry1.Parameters["@b"].Value = textBox5.Text.Split()[1];
                    changeQuerry1.Parameters["@c"].Value = textBox5.Text.Split()[2];
                    changeQuerry1.Parameters["@d"].Value = textBox5.Text.Split()[3];
                    changeQuerry1.Parameters["@e"].Value = textBox5.Text.Split()[4];
                    changeQuerry1.Parameters["@f"].Value = textBox5.Text.Split()[5];
                    changeQuerry1.ExecuteNonQuery(); 
                    
                    var changeQuerry2 = new SqlCommand("uupdate Client set client_Name = @a, client_Surname = @b, " +
                        "client_Otchestvo = @c, " +
                        $"client_Phone = @d, client_Email = @e where ID_client = '{id}'", con);
                    changeQuerry2.Parameters["@a"].Value = textBox1.Text;
                    changeQuerry2.Parameters["@b"].Value = textBox2.Text;
                    changeQuerry2.Parameters["@c"].Value = textBox3.Text;
                    changeQuerry2.Parameters["@d"].Value = textBox4.Text;
                    changeQuerry2.Parameters["@e"].Value = textBox6.Text;
                    changeQuerry2.Parameters["@f"].Value = textBox7.Text;
                    changeQuerry2.ExecuteNonQuery();


                    con.Close();
                }

            }

            database.ClosedConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            /*var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox1.Text;
            var name = textBox2.Text;
            var surname = textBox3.Text;
            var otch = textBox4.Text;
            string region = textBox4.Text.Split()[0];
            string city = textBox4.Text.Split()[1];
            string district = textBox4.Text.Split()[2];
            string street = textBox4.Text.Split()[3];
            string house = textBox4.Text.Split()[4];
            string appartment = textBox4.Text.Split()[5];
            var tel = textBox6.Text;
            var email = textBox7.Text;;

            dataGridView1.Rows[selectedRowIndex].SetValues(id, name, surname, otch, tel, email, region, city, district, street, house, appartment);
            dataGridView1.Rows[selectedRowIndex].Cells[14].Value = RowState.Modified;
            */
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forma item = new Forma();
            item.Show();
        }
    }
}

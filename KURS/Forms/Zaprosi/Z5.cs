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
namespace KURS.Forms.Zaprosi
{
    public partial class Z5 : Form
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
        public Z5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            int ID_order = (record.GetValue(0) == DBNull.Value) ? 0 : (int)record.GetValue(0);
            string client_Surname = (record.GetValue(10) == DBNull.Value) ? string.Empty : record.GetString(10);
            

            string clientAdress_Region = (record.GetValue(16) == DBNull.Value) ? string.Empty : record.GetString(16);
            string clientAdress_City = (record.GetValue(17) == DBNull.Value) ? string.Empty : record.GetString(17); 
            string clientAdress_District = (record.GetValue(18) == DBNull.Value) ? string.Empty : record.GetString(18);
            string clientAdress_Street = (record.GetValue(19) == DBNull.Value) ? string.Empty : record.GetString(19);
            string clientAdress_House = (record.GetValue(20) == DBNull.Value) ? string.Empty : record.GetString(20);
            string clientAdress_Appartment = (record.GetValue(21) == DBNull.Value) ? string.Empty : record.GetString(21);
            string item_Name = (record.GetValue(23) == DBNull.Value) ? string.Empty : record.GetString(23);

            dwg.Rows.Add(client_Surname, item_Name, ID_order, clientAdress_Region, clientAdress_City, clientAdress_District,
                clientAdress_Street, clientAdress_House, clientAdress_Appartment, RowState.ModifiedNew);
        }
        private void RefreshDataGrid1(DataGridView dwg, string city)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT *" +
                $"FROM Orders " +
                $"INNER JOIN Client ON Client.ID_client = Orders.ID_client" +
                $"INNER JOIN AdressOfClient ON AdressOfClient.ID_AdressOfClient = Client.ID_AdressOfClient  " +
                $"INNER JOIN Item ON Item.ID_item = Orders.ID_item " ;
                //$"where AdressOfClient.clientAdress_city = '{city}'";

            ; SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void CreateColumns_5()
        {
            dataGridView1.Columns.Add("client_Surname", "Фамилия клиента");
            dataGridView1.Columns.Add("item_Name", "Название товара");
            dataGridView1.Columns.Add("ID_order", "ID заказа");
            dataGridView1.Columns.Add("clientAdress_Region", "Регион");//8
            dataGridView1.Columns.Add("clientAdress_City", "Город");//9
            dataGridView1.Columns.Add("clientAdress_District", "Район");//10
            dataGridView1.Columns.Add("clientAdress_Street", "Улица");//11
            dataGridView1.Columns.Add("clientAdress_House", "Дом");//12
            dataGridView1.Columns.Add("clientAdress_Appartment", "Квартира");//13
            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void Z5_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=test_bd;Integrated Security=True");
            con.Open();

            CreateColumns_5();
            SqlDataReader dr3;
            DataTable dt3 = new DataTable();
            SqlCommand task3;
            task3 = new SqlCommand("Select * FROM Client INNER JOIN AdressOfClient ON AdressOfClient.ID_AdressOfClient = Client.ID_AdressOfClient ", con);
            dr3 = task3.ExecuteReader();
            dt3.Load(dr3);
            comboBox2.DisplayMember = "clientAdress_city";
            comboBox2.ValueMember = "ID_client";
            comboBox2.DataSource = dt3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = comboBox2.Text;
            RefreshDataGrid1(dataGridView1, a);
        }
    }
}

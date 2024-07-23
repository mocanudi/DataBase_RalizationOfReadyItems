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
    public partial class Z1 : Form
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
        public Z1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns_1()
        {
            dataGridView1.Columns.Add("ID_order", "ID заказа");//3
            dataGridView1.Columns.Add("ID_Delivery", "ID доставщика");//
            dataGridView1.Columns.Add("client_Surname", "Фамилия клиента");//
            dataGridView1.Columns.Add("item_Name", "Название товара");//


            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            int ID_order = (record.GetValue(0) == DBNull.Value) ? 0 : (int)record.GetValue(0);
            int ID_Delivery = (record.GetValue(8) == DBNull.Value) ? 0 : (int)record.GetValue(8);
            string client_Surname = (record.GetValue(15) == DBNull.Value) ? string.Empty : record.GetString(15);
            string item_Name = (record.GetValue(21) == DBNull.Value) ? string.Empty : record.GetString(21);

            dwg.Rows.Add(ID_order, ID_Delivery, client_Surname, item_Name, RowState.ModifiedNew);
        }
        private void RefreshDataGrid1(DataGridView dwg, string deliver)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT *" +
                $"FROM Orders " +
                $"INNER JOIN Delivery ON Delivery.ID_Delivery = Orders.ID_Delivery " +
                $"INNER JOIN Client ON Client.ID_client = Orders.ID_client " +
                $"INNER JOIN Item ON Item.ID_item = Orders.ID_item " +
                $"where Delivery.NameOfDeliveryMan = '{deliver}'";

;            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void Z1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=test_bd;Integrated Security=True");
            con.Open();

            CreateColumns_1();
            SqlDataReader dr3;
            DataTable dt3 = new DataTable();
            SqlCommand task3;
            task3 = new SqlCommand("Select * FROM Delivery", con);
            dr3 = task3.ExecuteReader();
            dt3.Load(dr3);
            comboBox2.DisplayMember = "NameOfDeliveryMan";
            comboBox2.ValueMember = "ID_Delivery";
            comboBox2.DataSource = dt3;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = comboBox2.Text;
            RefreshDataGrid1(dataGridView1, a);
        }
    }
}

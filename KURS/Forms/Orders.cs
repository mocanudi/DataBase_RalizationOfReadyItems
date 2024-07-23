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
    public partial class Orders : Form
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
        public Orders()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_order", "ID заказа");//0
            dataGridView1.Columns.Add("order_Cost", "Стоимость");//1
            dataGridView1.Columns.Add("order_Comment", "Комментарий");//2
            dataGridView1.Columns.Add("order_Date", "Дата заказа");//3
            dataGridView1.Columns.Add("order_Status", "Статус заказа");//4
            dataGridView1.Columns.Add("ID_Delivery", "ID доставки");//5
            dataGridView1.Columns.Add("ID_item", "ID товара");//6
            dataGridView1.Columns.Add("ID_client", "ID Клиента");//7
            dataGridView1.Columns.Add("item_Name", "Название товара");//8
            dataGridView1.Columns.Add("NameOfDeliveryMan", "Имя доставщика");//9
            dataGridView1.Columns.Add("client_Surname", "Имя клиента");//10
            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0),
                 record.GetInt32(1), record.GetString(2),
                 record.GetDateTime(3), record.GetString(4),

                 record.GetInt32(5), record.GetInt32(6),
                 record.GetInt32(7), record.GetString(8), 
                 record.GetString(9), record.GetString(10),
                 RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT Orders.*, Client.client_Name, Delivery.NameOfDeliveryMan, Item.item_Name " +
                $"FROM Orders INNER JOIN Delivery ON Orders.ID_Delivery = Delivery.ID_Delivery " +
                $"INNER JOIN Client ON Orders.ID_client = Client.ID_client " +
                $"INNER JOIN Item ON Orders.ID_item = Item.ID_item ";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void Reboot_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void Search(DataGridView dwg)
                {
                    
                }
        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[8].Value.ToString();
                textBox6.Text = row.Cells[9].Value.ToString();
                textBox7.Text = row.Cells[10].Value.ToString();

            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewOrder additem = new NewOrder();
            additem.Show();
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[11].Value = RowState.Deleted;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forma item = new Forma();
            item.Show();
        }
    }
}

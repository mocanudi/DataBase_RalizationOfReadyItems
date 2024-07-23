﻿using System;
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
    public partial class Z3 : Form
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
        public Z3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            int ID_order = (record.GetValue(0) == DBNull.Value) ? 0 : (int)record.GetValue(0);
            string client_Surname = (record.GetValue(10) == DBNull.Value) ? string.Empty : record.GetString(10);
            string item_Name = (record.GetValue(16) == DBNull.Value) ? string.Empty : record.GetString(16);

            dwg.Rows.Add(item_Name,ID_order, client_Surname, RowState.ModifiedNew);
        }
        private void RefreshDataGrid1(DataGridView dwg, string item)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT *" +
                $"FROM Orders " +
                $"INNER JOIN Client ON Client.ID_client = Orders.ID_client " +
                $"INNER JOIN Item ON Item.ID_item = Orders.ID_item " +
                $"where Item.item_Name = '{item}'";

            ; SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void CreateColumns_3()
        {
            dataGridView1.Columns.Add("item_Name", "Название товара");
            dataGridView1.Columns.Add("ID_order", "ID заказа");
            dataGridView1.Columns.Add("client_Surname", "Фамилия клиента");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void Z3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=test_bd;Integrated Security=True");
            con.Open();

            CreateColumns_3();
            SqlDataReader dr3;
            DataTable dt3 = new DataTable();
            SqlCommand task3;
            task3 = new SqlCommand("Select * FROM Item", con);
            dr3 = task3.ExecuteReader();
            dt3.Load(dr3);
            comboBox2.DisplayMember = "item_Name";
            comboBox2.ValueMember = "ID_item";
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

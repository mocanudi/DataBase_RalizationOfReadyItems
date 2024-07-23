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
    public partial class Z2 : Form
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
        public Z2()
        {
            InitializeComponent();
        }

        private void CreateColumns2()
        {
            dataGridView1.Columns.Add("ID_item", "ID");
            dataGridView1.Columns.Add("item_Name", "Название");
            dataGridView1.Columns.Add("item_Type", "Категория");
            dataGridView1.Columns.Add("item_Unit", "Единица измерения");
            dataGridView1.Columns.Add("item_Price", "Цена");
            dataGridView1.Columns.Add("item_Supplier", "Поставщик материалов");
            dataGridView1.Columns.Add("item_Photo", "Фото");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),
                record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid2(DataGridView dwg, int price)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT *" +
                $"FROM Item " +
                $"where item_Price BETWEEN 0 and '{price}'";

            ; SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void Z2_Load(object sender, EventArgs e)
        {
            CreateColumns2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox1.Text);

            RefreshDataGrid2(dataGridView1, price);
        }
    }
}

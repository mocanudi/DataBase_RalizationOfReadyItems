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
    public partial class Items : Form
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
        

        public Items()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns() {
            dataGridView1.Columns.Add("ID_item", "ID");
            dataGridView1.Columns.Add("item_Name", "Название");
            dataGridView1.Columns.Add("item_Type", "Категория");
            dataGridView1.Columns.Add("item_Unit", "Единица измерения");
            dataGridView1.Columns.Add("item_Price", "Цена");
            dataGridView1.Columns.Add("item_Supplier", "Поставщик материалов");
            dataGridView1.Columns.Add("item_Photo", "Фото");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record) {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),
                record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dwg) {
            dwg.Rows.Clear();

            string querystring = $"select * from Item";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void Items_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Enter_label_Click(object sender, EventArgs e)
        {

        }


        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();
            string searchString = $"select * from Item where concat (ID_item, item_Name, item_Type, item_Unit, item_Price, item_Supplier, item_Photo) " +
                $"like '%" + Search_tb.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }

            reader.Close();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();

            }
        }

        private void Reboot_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewItem additem = new NewItem();
            additem.Show();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if(dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
            }
        }


        private new void Update()
        {
            database.OpenConnection();
            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"delete from Item where id = '{id}'";

                    var command = new SqlCommand(deleteQuerry, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var unit = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var supplier = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var photo = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuerry = $"update Item set item_Name = '{name}', item_Type = '{type}', item_Unit = '{unit}', " +
                        $"item_Price = '{price}', item_Supplier = '{supplier}', item_Photo = '{photo}'" +
                        $"where ID_item = '{id}'";

                    var command = new SqlCommand(changeQuerry, database.getConnection());
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


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox1.Text;
            var name = textBox2.Text;
            var type = textBox3.Text;
            var unit = textBox4.Text;
            var supplier = textBox6.Text;
            var photo = textBox7.Text;
            int price;
            if (int.TryParse(textBox5.Text, out price))
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, type, unit, price, supplier, photo);
                dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
            }
            else
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forma item = new Forma();
            item.Show();
        }
    }
}

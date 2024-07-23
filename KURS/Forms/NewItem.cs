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
    public partial class NewItem : Form
    {
        DataBase database = new DataBase();

        public NewItem()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            item.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            database.OpenConnection();

            var name = textBox2.Text;
            var type = textBox3.Text;
            var unit = textBox4.Text;
            var supplier = textBox6.Text;
            var photo = textBox7.Text;
            int price;
            if(int.TryParse(textBox5.Text, out price))
            {
                var addQuerry = $"insert into Item (item_Name, item_Type, item_Unit, item_Price, item_Supplier, item_Photo) values" +
                    $"('{name}', '{type}', '{unit}', '{price}', '{supplier}', '{photo}')";

                var command = new SqlCommand(addQuerry, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Товар добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Цена должна именть цифроваой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            database.ClosedConnection();
        }

        private void NewItem_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

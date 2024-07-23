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
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Enter_label_Click(object sender, EventArgs e)
        {
            
        }

        private void Clients_btn_Click(object sender, EventArgs e)
        {
            Clients frm1 = new Clients();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void Items_btn_Click(object sender, EventArgs e)
        {
            Items frm = new Items();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        DataBase database = new DataBase();



        private void Forma_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=test_bd;Integrated Security=True");
            con.Open();
            

            comboBox1.Items.Add("Просмотр списка заказов, доставляемых одним доставщиком");
            comboBox1.Items.Add("Поиск списка товаров по диапазону стоимости");
            comboBox1.Items.Add("Поиск списка заказов по запрашиваемому товару");
            comboBox1.Items.Add("Просмотр списка заказов определённого покупателя");
            comboBox1.Items.Add("Отобразить заказы в определённый город");
            

            con.Close();

            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Clients frm1 = new Clients();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void Orders_btn_Click(object sender, EventArgs e)
        {
            Orders frm1 = new Orders();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delivery frm1 = new Delivery();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=test_bd;Integrated Security=True");
            con.Open();
            switch (comboBox1.Text)
            {
                case "Просмотр списка заказов, доставляемых одним доставщиком":

                    Zaprosi.Z1 item = new Zaprosi.Z1();
                    item.Show();
                    break;
                case "Поиск списка товаров по диапазону стоимости":
                    Zaprosi.Z2 item2 = new Zaprosi.Z2();
                    item2.Show();
                    break;
                case "Поиск списка заказов по запрашиваемому товару":
                    Zaprosi.Z3 item3 = new Zaprosi.Z3();
                    item3.Show();
                    break;
                case "Просмотр списка заказов определённого покупателя":
                    Zaprosi.Z4 item4 = new Zaprosi.Z4();
                    item4.Show();
                    break;
                case "Отобразить заказы в определённый город":
                    Zaprosi.Z5 item5 = new Zaprosi.Z5();
                    item5.Show();
                    break;

            }
            con.Close();
        }

        
    }
}

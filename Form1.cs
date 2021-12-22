using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяТРПО
{
    public partial class Form1 : Form
    {
        public static List<People> table_of_people = new List<People>();
        public static List<People> SortList = new List<People>();
        public Form1()
        {
            InitializeComponent();
           
            People product = new People(1, "Бочкарёва", "Ж", "Отдел Образовния", "12.06.1984", 2010, "Преподаватель", 15000);
            table_of_people.Add(product);
            product = new People(2, "Марков", "М", "Отдел Безопасности", "11.09.1955", 1987, "Охранник", 17000);
            table_of_people.Add(product);
            product = new People(3, "Смирнова", "Ж", "Отдел Кулинарии", "23.12.1974", 2000, "Повар", 9000);
            table_of_people.Add(product);
            ShowList(table_of_people);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowList(table_of_people);
        }

        public void ShowList(List<People> table)
        {
            dataGridView1.Rows.Clear();
            
            
                foreach (People item in table)
                    dataGridView1.Rows.Add(item.code, item.fam, item.pol, item.nazot, item.db, item.datepost, item.dolj, item.oklad);
            
            
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            ShowList(table_of_people);
        }

            private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Increase increase = new Increase();
            increase.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = 12672;
            int count = 0;
            int kolvo = 0;
            int year = 2021;
            int staj = 0;
            double sum = 0;
            foreach (People item in table_of_people)
            {
                if (item.datepost != 0)
                {
                    staj += year - item.datepost;
                sum = staj;

                label2.Text = $"{sum} лет";

                    ++count;
                }
                if (item.oklad < num)
                {
                    ++kolvo;
                }
                label4.Text = $"{sum / count} лет";
                label6.Text = $"{kolvo}";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table table = new table();
            table.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SortList.Clear();
            int pens = 65;
            int a = 2021;
            foreach (People item in table_of_people)
            {
                if (Convert.ToInt32(a - Convert.ToDateTime(item.db).Year) >= pens)
                SortList.Add(item);
            }
        }
        
    }
}
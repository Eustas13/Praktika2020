using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesia1
{
    public partial class Список_заказов : Form
    {
        Model1 db = new Model1();
        public Список_заказов()
        {
            InitializeComponent();
        }

        private void Список_заказов_Load(object sender, EventArgs e)
        {
            заказBindingSource.DataSource = db.Заказ.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                MessageBox.Show("Статус заказа успешно изменён!");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Менеджер : Form
    {
        public Менеджер()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.FORMA.Show();
        }

        private void Менеджер_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Список_изделий список_изделий = new Список_изделий();
            список_изделий.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Список_заказов список_заказов = new Список_заказов();
            список_заказов.Show();
        }
    }
}

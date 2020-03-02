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
    public partial class Дирекция : Form
    {
        public Дирекция()
        {
            InitializeComponent();
        }

        private void Дирекция_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Список_изделий список_изделий = new Список_изделий();
            список_изделий.Show();
        }
    }
}

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
    public partial class Список_изделий : Form
    {
        Model1 db = new Model1();
        public Список_изделий()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Список_изделий_Load(object sender, EventArgs e)
        {
            изделияBindingSource.DataSource = db.Изделия.ToList();
        }

    }
}

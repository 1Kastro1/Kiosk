using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kiosk.Формы;

namespace Kiosk.Формы
{
    public partial class Korzina : Form
    {
        Model1 db = new Model1();
        public Korzina()
        {
            InitializeComponent();
        }

        private void Korzina_Load(object sender, EventArgs e)
        {
            КорзинаBindingSource.DataSource = db.Корзина.ToList();
            ЗаказBindingSource.DataSource = db.Заказ.ToList();
            formNameLb1.Text = "список Продуктов";
        }
    }
}

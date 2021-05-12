using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk.Формы
{
    public partial class Пироги : Form
    {
        public Пироги()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Меню fr1 = new Меню();
            fr1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Чуду fr2 = new Чуду();
            fr2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Десерты fr3 = new Десерты();
            fr3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Пироги fr5 = new Пироги();
            fr5.Show();
            this.Hide();
        }
    }
}

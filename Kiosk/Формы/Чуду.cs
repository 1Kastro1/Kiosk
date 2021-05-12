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
    public partial class Чуду : Form
    {
        Model1 db = new Model1();
        public Чуду()
        {
            InitializeComponent();
        }
        List<Заказ> lstProduct = new List<Заказ>();


        List<UserControl1> lstControls = new List<UserControl1>();

        List<Image> imgCol;


        private void button1_Click(object sender, EventArgs e)
        {
            Меню fr1 = new Меню();
            fr1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Десерты fr3 = new Десерты();
            fr3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Напитки fr4 = new Напитки();
            fr4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Пироги fr5 = new Пироги();
            fr5.Show();
            this.Hide();
        }

        private void Чуду_Load(object sender, EventArgs e)
        {
            lstControls.Add(UserControl1);
            lstControls.Add(UserControl2);
            lstControls.Add(UserControl3);
            lstControls.Add(UserControl4);
            lstControls.Add(UserControl5);
            lstControls.Add(UserControl6);

            // создаем коллекцию товаров из модели EF
            lstProduct = db.Заказ.ToList();

            // загружаем данные в пользов. элементы управления
            UserControlLoad();
        }
        int ProdNumber = 0;

        private void UserControlLoad();
    }
        
}










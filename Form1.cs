using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            if (domType.SelectedIndex < 0 || domSize.SelectedIndex < 0)
                MessageBox.Show("Укажите тип вещи и размер");
            else
            {
                Order order = new Order();
                order.Launch(domType.SelectedItem.ToString(), domSize.SelectedItem.ToString());
                DialogResult dialogResult = MessageBox.Show($"Ваш заказ {order.singleton.type} размера {order.singleton.size}. Верно?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Random rand = new Random();
                    int r = rand.Next(1, 5);
                    if (r == 1)
                    {
                        MessageBox.Show("Мы приступили к выполнению вашего заказа", "Ожидайте", MessageBoxButtons.OK);
                        MessageBox.Show("Ваш заказ готов. Вы можете его забрать.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (r == 2)
                    {
                        MessageBox.Show("Извините, мыши сгрызли все нитки...", "", MessageBoxButtons.OK);
                    }
                    if (r == 3)
                    {
                        MessageBox.Show("Случилось перенапряжение сети и швейные машины перестали работать", "Неполадочки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (r == 4)
                    {
                        MessageBox.Show("Король запретил носить одежду и мы не можем выполнить ваш заказ", "Указ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}

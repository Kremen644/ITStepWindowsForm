using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GoodsEditor : Form
    {

        private Form1 _parrentList;
        private Goods _goods;
        public GoodsEditor (Form1 parrentList, Goods goods = null)
        {
            InitializeComponent();
            _parrentList = parrentList ?? throw new ArgumentNullException(nameof(parrentList));
            _goods = goods;
            if (goods != null)
            {
                this.Text = "Редактирование товара";
                textBox1.Text = _goods.Name;
                textBox2.Text = _goods.Country;
                textBox3.Text = _goods.Price.ToString();
            }
            else
                this.Text = "Добавление товара";
                

            
        }
        //public GoodsEditor()
        //{
        //    InitializeComponent();
        //}

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                    Goods newGoods = new Goods
                    {
                        Name = textBox1.Text,
                        Country = textBox2.Text,
                        Price = Double.Parse(textBox3.Text)
                    };
                    if (_goods == null)
                        _parrentList.AddGoods(newGoods);
                    else
                        _parrentList.EditGoods(newGoods);
                    this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + " : Имя и страна товара не должны быть пустыми, цена >= 0",
                    "Ошибка редактирования товара",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

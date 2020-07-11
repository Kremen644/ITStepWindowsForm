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
    public partial class Form1 : Form
    {
        public Goods goods = null;
        public Form1()
        {
            InitializeComponent();
        }
        public void AddGoods (Goods goods)
        {
            this.listBox1.Items.Add(goods);
        }
        public void EditGoods(Goods goods)
        {
            this.listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            this.listBox1.Items.Add(goods);
        }
        /// <summary>
        /// Добавить товар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            GoodsEditor goodsEditor = new GoodsEditor(this, goods);
            goodsEditor.Show();

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Очистить список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }
        /// <summary>
        /// Удалить товар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        

        /// <summary>
        /// Редактировать товар
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            var goods = (Goods)this.listBox1.SelectedItem;
            GoodsEditor goodsEditor = new GoodsEditor(this, goods);
            goodsEditor.Show();
        }
    }
}

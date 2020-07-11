using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SplitterTrue : Form
    {
        public SplitterTrue()
        {
            InitializeComponent();
            this.шрифтToolStripMenuItem.Checked = true;
            this.шрифт2ToolStripMenuItem.Checked = false;
            this.шрифт3ToolStripMenuItem.Checked = false;
            this.style1ToolStripMenuItem.Checked = true;
            this.style2ToolStripMenuItem.Checked = false;
            this.style3ToolStripMenuItem.Checked = false;
            this.menuStrip2.Visible = false;
            this.menuStrip1.Visible = true;
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            open.FilterIndex = 2;

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
        /// <summary>
        /// Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            save.FilterIndex = 2;

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(save.FileName))
                {
                    writer.Write(textBox1.Text);
                }
            }
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            open.FilterIndex = 2;

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            save.FilterIndex = 2;

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(save.FileName))
                {
                    writer.Write(textBox1.Text);
                }
            }
        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            this.шрифтToolStripMenuItem.Checked = true;
            this.шрифт2ToolStripMenuItem.Checked = false;
            this.шрифт3ToolStripMenuItem.Checked = false;
        }

        private void Шрифт2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            this.шрифтToolStripMenuItem.Checked = false;
            this.шрифт2ToolStripMenuItem.Checked = true;
            this.шрифт3ToolStripMenuItem.Checked = false;
        }

        private void Шрифт3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;
            this.шрифтToolStripMenuItem.Checked = false;
            this.шрифт2ToolStripMenuItem.Checked = false;
            this.шрифт3ToolStripMenuItem.Checked = true;
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            open.FilterIndex = 2;

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            save.FilterIndex = 2;

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(save.FileName))
                {
                    writer.Write(textBox1.Text);
                }
            }
        }

        private void Style1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            this.style1ToolStripMenuItem.Checked = true;
            this.style2ToolStripMenuItem.Checked = false;
            this.style3ToolStripMenuItem.Checked = false;
        }

        private void Style2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            this.style1ToolStripMenuItem.Checked = false;
            this.style2ToolStripMenuItem.Checked = true;
            this.style3ToolStripMenuItem.Checked = false;
        }

        private void Style3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;
            this.style1ToolStripMenuItem.Checked = false;
            this.style2ToolStripMenuItem.Checked = false;
            this.style3ToolStripMenuItem.Checked = true;
        }

        private void ChangeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void СменитьЯзыкToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip2.Visible = true;
            this.menuStrip1.Visible = false;
        }

        private void РусскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip2.Visible = false;
            this.menuStrip1.Visible = true;
        }

        private void РусскийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.menuStrip2.Visible = false;
            this.menuStrip1.Visible = true;
        }

        private void EnglishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.menuStrip2.Visible = true;
            this.menuStrip1.Visible = false;
        }
    }
}

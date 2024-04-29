using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_07
{
    public partial class MainForm : Form
    {
        private Form startForm;
        public IVectorable[] VecArr { get; set; }
        public int Length { get; private set; }
        public MainForm(Form form)
        {
            InitializeComponent();
            startForm = form;
            Length = 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Length = (int)numericUpDown1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            try
            {
                VecArr = VectorController.ReadVectors(Length, textBox1.Text);
                for (int i = 0; i < Length; i++)
                {
                    textBox2.AppendText(VecArr[i].ToString() + "\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new ProgramForm(this, VecArr);
            form.BackColor = BackColor;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Hide();
        }
    }
}

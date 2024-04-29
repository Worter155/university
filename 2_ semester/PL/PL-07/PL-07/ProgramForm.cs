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
    public partial class ProgramForm : Form
    {
        IVectorable[] vecArr;
        Form mainForm;

        public ProgramForm(Form form, IVectorable[] vecArr)
        {
            InitializeComponent();
            mainForm = form;
            this.vecArr = vecArr;
        }

        private void ProgramForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = vecArr.Length;
            numericUpDown2.Maximum = vecArr.Length;
            try
            {
                for (int i = 0; i < vecArr.Length; i++)
                {
                    textBox1.AppendText(vecArr[i].ToString() + "\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            textBox2.AppendText($"Сумма {(int)numericUpDown1.Value} и {(int)numericUpDown2.Value} векторов\r\n");
            textBox2.AppendText(Vectors.Sum(vecArr[(int)numericUpDown1.Value-1], vecArr[(int)numericUpDown2.Value-1]).ToString() + "\r\n");
        }

        private void ScalarButton_Click(object sender, EventArgs e)
        {
            textBox2.AppendText($"Скалярное произведение {(int)numericUpDown1.Value} и {(int)numericUpDown2.Value} векторов\r\n");
            textBox2.AppendText(Vectors.Scalar(vecArr[(int)numericUpDown1.Value - 1], vecArr[(int)numericUpDown2.Value - 1]).ToString() + "\r\n");
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            textBox2.AppendText($"Сравнение {(int)numericUpDown1.Value} и {(int)numericUpDown2.Value} векторов\r\n");
            if (vecArr[(int)numericUpDown1.Value - 1].Equals(vecArr[(int)numericUpDown2.Value - 1])) textBox2.AppendText("Вектора равны\r\n");
            else textBox2.AppendText("Вектора не равны\r\n");
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            IVectorable cl = (IVectorable)vecArr[(int)numericUpDown1.Value-1].Clone();
            textBox2.AppendText("Клонируемый вектор\r\n");
            textBox2.AppendText(vecArr[(int)numericUpDown1.Value-1].ToString()+"\r\n");
            textBox2.AppendText("Клонированный вектор\r\n");
            textBox2.AppendText(cl.ToString()+"\r\n");
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("Все максимальные вектора\r\n");
            IVectorable[] max = VectorController.MaxVectors(vecArr);
            for (int i = 0; i < max.Length; i++)
            {
                textBox2.AppendText(max[i].ToString() + "\r\n");
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("Все минимальные вектора\r\n");
            IVectorable[] min = VectorController.MinVectors(vecArr);
            for (int i = 0; i < min.Length; i++)
            {
                textBox2.AppendText(min[i].ToString() + "\r\n");
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("Массив после сортировки\r\n");
            IVectorable[] vec = VectorController.Sort(vecArr);
            for(int i = 0; i < vec.Length; i++)
            {
                textBox2.AppendText(vec[i].ToString() + "\r\n");
            }
        }

        private void WriteByteStreamButton_Click(object sender, EventArgs e)
        {
            try
            {
                VectorController.WriteByteStream(vecArr);
                textBox2.AppendText("Вектора успешно сохранены в файл test.dat\r\n");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadByteStreamButton_Click(object sender, EventArgs e)
        {
            try
            {
                IVectorable[] vec = VectorController.ReadByteStream();
                textBox2.AppendText("Чтение векторов с файла test.dat через байтовый поток\r\n");
                for (int i = 0; i<vec.Length; i++)
                {
                    textBox2.AppendText(vec[i].ToString() + "\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteCharStreamButton_Click(object sender, EventArgs e)
        {
            try
            {
                VectorController.WriteCharStream(vecArr);
                textBox2.AppendText("Вектора успешно сохранены в файл test.txt\r\n");
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadCharStreamButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.AppendText("Чтение векторов с файла test.txt через символьный поток\r\n");
                IVectorable[] vec = VectorController.ReadCharStream();
                for (int i = 0; i < vec.Length; i++)
                {
                    textBox2.AppendText(vec[i].ToString() + "\r\n");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerealizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                IVectorable[] vec = VectorController.Serialize(vecArr);
                textBox2.AppendText("Вектора успешно сохранены в файл test.bin с помощью сериализации\r\n");
                for (int i = 0; i < vec.Length; i++)
                {
                    textBox2.AppendText(vec[i].ToString() + "\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

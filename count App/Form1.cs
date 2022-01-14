using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace count_App
{
    public partial class myForm : Form
    {
        int n = 0;
        int min = 0;
        int max = 1000000;
        Random random = new Random();
        public myForm()
        {
            InitializeComponent();
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это моё первая программа на C#\nЭто счётчик", "О программе");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            n++;
            count.Text = Convert.ToString(n);
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            n--;
            count.Text = Convert.ToString(n);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            n = 0;
            count.Text = Convert.ToString(n);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {

            if (minNumber.Text != "") {
                min = Convert.ToInt32(minNumber.Text);
            }
            else 
            {
                min = 0;
            }
            if (maxNumber.Text != "")
            {
                max = Convert.ToInt32(maxNumber.Text);
            }
            else 
            {
                max = 1000000;
            }
            if (checkRepeat.Checked)
            {
                int number = random.Next(min, max);
                rabdomText.Text = number.ToString();
                if (memaryNumbers.Text.IndexOf(number.ToString()) == -1)
                {
                    memaryNumbers.AppendText($"{number}\n");
                }
            }     
            else 
            {
                int number = random.Next(min, max);
                rabdomText.Text = number.ToString();
                memaryNumbers.AppendText($"{number}\n");
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(memaryNumbers.Text);
        }

        private void вставитьДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloknot.AppendText(DateTime.Now.ToShortDateString()+"\n");
        }

        private void вставитьВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bloknot.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Сохранение файла";
            fileDialog.Filter = "Текстовый файл|*.txt|DOC-файл|*.doc|DOCX-файл современный формат|*.docx|RTF-файл|*.rtf";
            fileDialog.ShowDialog();
            if (fileDialog.FileName!="") {
                System.IO.File.WriteAllText(fileDialog.FileName, Bloknot.Text);
                MessageBox.Show("Файл сохранён");
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Открытие файла";
            fileDialog.Filter = "Текстовый файл|*.txt|DOC-файл|*.doc|DOCX-файл современный формат|*.docx|RTF-файл|*.rtf";
            fileDialog.ShowDialog();
            if (fileDialog.FileName != "")
            {
                string text=System.IO.File.ReadAllText(fileDialog.FileName);
                Bloknot.Text = text;
            }
        }

        private void myForm_Load(object sender, EventArgs e)
        {
            if (tabPage2.Controls.IsReadOnly)
            {
                blok.Enabled = true;
            }
            else 
            {
                blok.Enabled = false;
            }
            
        }

      

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Text == "Блокнот")
            {
                blok.Enabled = true;
            }
            else 
            {
                blok.Enabled = false;
            }
           
        }
    }

    
}

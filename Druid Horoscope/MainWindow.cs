using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Druid_Horoscope
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            DateTime date = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            if((date.Day >= 23 && date.Day == 1) && (date.Month == 12|| date.Month == 1))//(date >= Convert.ToDateTime("23.12." + dateTimePicker1.Value.Year) && date <= Convert.ToDateTime("01.01." + dateTimePicker1.Value.Year+1) ||
               //date >= Convert.ToDateTime("25.06." + dateTimePicker1.Value.Year) && date <= Convert.ToDateTime("04.07." + dateTimePicker1.Value.Year)) //Яблоня
                richTextBox1.Text = date.ToString() + "\n" + Convert.ToDateTime("23.12." + dateTimePicker1.Value.Year);
            //pictureBox1.Image = Image.FromFile("Орех.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
        }
    }
}

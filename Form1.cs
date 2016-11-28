using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DesligarPc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            if (selectedItem == "5 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 300");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "10 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 600");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "20 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 1200");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "30 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 1800");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "40 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 2400");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "60 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 3600");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "120 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 7200");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "240 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 14400");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "360 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 21600");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else if (selectedItem == "720 Minutos")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 43200");
                MessageBox.Show("Seu Computador será desligado em : " + selectedItem.ToString());
            }
            else
            {
                MessageBox.Show("O Horário não pode ser selecionado.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-a");
        }
    }
}

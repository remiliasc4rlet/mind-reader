using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akıl_Okuyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int data;
            if (!int.TryParse(textBox1.Text, out data))
            {
                MessageBox.Show("Lütfen programın tahmin edebilmesi için bir sayı girin.");
                return;
            }
            textBox1.Text = null;
            Form2 form2 = new Form2();
            form2.Data = data;
            form2.Show();
            await Task.Delay(6500);
        }

    }
}

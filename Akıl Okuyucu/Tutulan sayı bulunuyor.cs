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
    public partial class Form2 : Form
    {
        
        private int _data;

        public int Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private async  void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
            for (int i = 1; i <= 100; i++)
            {

                if (i == 1)
                {
                    label1.Text = "   Beyin dalgaları taranıyor...";
                    await Task.Delay(10);
                }
                else if (i > 2 && i < 19)
                {
                    await Task.Delay(50);
                }
                else if (i == 20)
                {
                    await Task.Delay(80);
                    label1.Text = "Nöron aktiviteleri inceleniyor...";
                }
                else if (i == 50)
                {
                    label1.Text = "  Sinir hareketleri işleniyor...";
                    await Task.Delay(100);
                }
                else if (i == 75)
                {
                    label1.Text = "     Anılar kontrol ediliyor...";
                    await Task.Delay(200);
                }
                else if (i == 87)
                {
                    label1.Text = "    Olasılıklar hesaplanıyor...";
                    await Task.Delay(200);
                }
                else if (i == 95)
                {
                    label1.Text = "                   Başarılı!";
                }
                else if (i == 100)
                {
                    await Task.Delay(550);
                }
                progressBar1.Value = i;
                await Task.Delay(20); // her adım için 50 ms bekle
            }

            this.Close();
            Form3 form3 = new Form3();
            form3.Data2 = Data;
            form3.Show();
            this.Close();
        }
    }
}

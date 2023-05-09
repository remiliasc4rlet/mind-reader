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
    public partial class Form3 : Form
    {
        private int _data;

        public int Data2
        {
            get { return _data; }
            set { _data = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = string.Format("Aklından geçen sayı {0}", Data2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

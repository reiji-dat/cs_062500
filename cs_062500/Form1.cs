using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_062500
{
    public partial class Form1 : Form
    {
        int kaisuu;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mybutton1.Visible = false;

            /*
            //int a = 1;
            //MessageBox.Show(""+ (10/a));
            mybutton1.Enabled = false;
            button2.Visible = true;
             */
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            kaisuu += 1;
            if(kaisuu <= 3){
                MessageBox.Show("押すなって言ったのに");
                mybutton1.Text = "本当に押すなよ？";
            }
            else
            {
                MessageBox.Show("……。");
                mybutton1.Text = "……。";
            }
            mybutton1.Enabled = true;
            button2.Visible = false;
             */
        }
    }
}

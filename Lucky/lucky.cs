using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lucky
{
    public partial class lucky : Form
    {
        public lucky()
        {
            InitializeComponent();
        }
        public static void progress(bool set=true)
        {
            Form1 barprogress1 = new Form1(set);
            //多线程控制
            barprogress1.Show();
            //Application.Run(barprogress1);
        }
        public bool se = true;
        private void button1_Click(object sender, EventArgs e)
        {
            string path_str = Directory.GetCurrentDirectory() + "\\";
            parameter.name = File.ReadAllLines(path_str+"name");
            int k = 3;
            se = true;
            progress();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            se = false;
        }
    }
}

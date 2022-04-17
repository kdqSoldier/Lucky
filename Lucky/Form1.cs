using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace Lucky
{
    public partial class Form1 : Form
    {
        private delegate void SetPos(int ipos, string vinfo);//创建代理
        public Form1()
        {
            InitializeComponent();
        }

        public bool type_;
        public int i_;
        public Form1(bool type = true)
        {
            InitializeComponent();
            type_ = type;
        }
        public string[] name = new string[] {};
         private void SetText(int ipos, string vinfo)
        {
            if (this.InvokeRequired)
            {
                SetPos setPos = new SetPos(SetText);
                this.Invoke(setPos, new object[] { ipos, vinfo });
            }
            else if (vinfo == "OK")
            {
                this.label1.Text = parameter.name[ipos].ToString();
            }
            else
            {
                if (vinfo == "OK")
                {
                    this.label1.Text= parameter.name[ipos].ToString();
                }
                else
                {
                    this.label1.Text = parameter.name[ipos].ToString();
                }
            }
        }
        /// <summary>
        /// 新的线程执行函数
        /// </summary>
        private void runprogress()
        {
            int  j = 0;
            while (true)
            {
                if (type_==true)
                {
                    if (j<84)
                    {
                        SetText(j, "OK");
                        j++;
                    }
                    else
                    {
                        j = 0;
                    }
                }
                else if (type_==false)
                {                   
                    SetText(j, "NO");
                    break;
                }
                Thread.Sleep(000);
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Thread timeprogress = new Thread(new ThreadStart(runprogress));
            timeprogress.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type_ = false;
        }
    }
}

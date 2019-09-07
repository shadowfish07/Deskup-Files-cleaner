using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 桌面文件清理
{
    public partial class avoidList : Form
    {
        public avoidList()
        {
            InitializeComponent();
            for (int i = 0; i < Data.AvoidList.Length; i++)
            {
                if(Data .AvoidList[i]!="" && Data.AvoidList[i] !=null ) textBox1.Text += Data.AvoidList[i] + "\r\n";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Lines.Length ; i++)
            {
                Data.AvoidList[i] = textBox1.Lines[i];
            }
            
        }
        public static  bool CheckAovidList(string path)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (path == Data.AvoidList[i]) return true;
            }
            return false;
        }
    }
}

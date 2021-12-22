using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DSXresolutionChange
{
    public partial class Form1 : Form
    {
        OpenFileDialog od = new OpenFileDialog();
        bool fileOpened;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello from dan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            od.ShowDialog();
            fileOpened = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(od.FileName));
            bw.BaseStream.Position = 0x14;
            bw.Write(0x16);
            bw.BaseStream.Position = 0x2e;
            bw.Write(0x02);
            bw.Close();
            Console.WriteLine("Success");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(od.FileName));
            bw.BaseStream.Position = 0x15;
            bw.Write(0x01);
            bw.Close();
            Console.WriteLine("Succeeded");
        }
    }
}

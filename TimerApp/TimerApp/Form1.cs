using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")] // この行を追加
        private static extern bool AllocConsole();                 // この行を追加  
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
        }

        private int duration = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Start();
            timer1.Interval = 1000;
            
        }
        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                timer1.Stop();
                timer1.Dispose();
                duration = 10;
                return;
            }
            else if (duration > 0)
            {
                duration--;
                label1.Text = duration.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime stime = DateTime.Now;
            Console.WriteLine(stime.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

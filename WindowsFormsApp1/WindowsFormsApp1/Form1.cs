using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLoad;
using ClassLibrary1;
using ClassLibrary2;
using ClassLibrary3;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "テストメッセージ";
            TestClass test1 = new TestClass(1, path);
            Console.WriteLine(test1.getProperty());
            string filepath = "D:\\Program\\Csharp\\RdmWordQuiz\\RdmWordQuiz\\bin\\Debug\\words.txt";
            List<string> str_list = test1.getList(filepath);
            foreach(string str in str_list)
            {
                Console.WriteLine(str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "テストメッセージ２";
            TestClass2 test1 = new TestClass2(1, path);
            //string filepath = "D:\\Program\\Csharp\\RdmWordQuiz\\RdmWordQuiz\\bin\\Debug\\words.txt";
            //List<string> str_list = test1.getList(filepath);
            //foreach(string str in str_list)
            //{
            //    Console.WriteLine(str);
            //}


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "テストメッセージ３";
            Class3 test1 = new Class3(3, path);
        }
    }
}

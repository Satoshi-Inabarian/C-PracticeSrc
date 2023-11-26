using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//自作ライブラリ
using ClassConstructor;
using ClassJudgeQOM;
using SatoLib;
namespace WindowsFormsTestApp
{
    public partial class Form1 : Form
    {
        //コンソールライブラリ使用
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        /// <summary>
        /// メンバ変数
        private static extern bool AllocConsole();
        private string txt;
        private double num;
        //コンストラクタ
        public Form1()
        {
            InitializeComponent();
        }
        //コンストラクタ終わり

        private void BtnProgram_Click(object sender, EventArgs e)
        {


            Console.WriteLine("Start");

            /////////ここにテストソース//////////////
            library.countTimer(5);
            ////////おわり//////////////////////////

            Console.WriteLine("End");



        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }
    }
}

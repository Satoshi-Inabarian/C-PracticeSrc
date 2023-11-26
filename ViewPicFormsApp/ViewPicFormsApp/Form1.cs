using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewPicFormsApp
{
    public partial class Form1 : Form
    {
        //メンバ変数（インスタンス変数）用意 フォーム内で受け渡し・上書き・変更できる変数のこと。
        //詳しくは下記イベントハンドラ( BtnValueChange_Click)内の記述を参照すること
        List<Image> imglist = new List<Image>();
        List<string> list_str = new List<string>() { "あ","い","う","え","お"};
        public Form1()
        {
            //コンポーネント立ち上げ
            InitializeComponent();


        }
        
        private static List<Image> getImageList(string filepath)
        {
            List<string> pathlist = GetFilePaths(filepath);
            List<Image> imglist = new List<Image>();
            foreach (string path in pathlist)
            {
                Image temp = Image.FromFile(path);
                imglist.Add(temp);
            }
            return imglist;
        }

        private static List<String> GetFilePaths(String path)
        {
            List<String> files = new List<String>();

            string[] dirs = Directory.GetFiles(path, "*.jpg");
            foreach (string dir in dirs)
            {
                files.Add(dir);
            }
            return files;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string path = TextBox_FIleDir.Text;
            List<Image> tmp_imglist = getImageList(path);
            imglist = tmp_imglist;
            foreach(Image img in imglist)
            {
                //pictureBox1.Image = img;
                Task.Factory.StartNew(() => pictureBox1.Image = img);
            }
        }

        public void BtnChangeDir_Click(object sender, EventArgs e)
        {
            using (var cofd = new CommonOpenFileDialog()
            {
                Title = "フォルダを選択してください",
                // フォルダ選択モードにする
                RestoreDirectory = true,
                IsFolderPicker = true,
            })
            {
                if (cofd.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }

                // FileNameで選択されたフォルダを取得する
                TextBox_FIleDir.Text = cofd.FileName;
            }
            imglist.Clear();
            //List<Image> imglist_tmp= getImageList(path);
            
            
            
        }


        //メンバ変数 list string内の要素を変更するイベントハンドラー
        private void BtnValueChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"list_str:{list_str.Count}");
            foreach(string str in list_str)
            {
                MessageBox.Show(str);
            }
            list_str.Clear();
            List<string> list_strchange = new List<string>() { "か","き","く","け","こ"};
            list_str = list_strchange;  
        }
    }


}

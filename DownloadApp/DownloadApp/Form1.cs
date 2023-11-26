using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DownloadApp
{
    public partial class Downloder : Form
    {
        string mySavePath = null;
        public Downloder()
        {
            InitializeComponent();
        }

        private void BtnDl_Txt_Click(object sender, EventArgs e)
        {
            Console.WriteLine("DownLoading from:{0}",mySavePath);
            if (mySavePath == null)
            {
                MessageBox.Show("ファイルをダウンロードして下さい。", "エラー");
                return;
            }
            if (!System.IO.File.Exists(mySavePath))
            {
                MessageBox.Show("指定ファイルが存在しません。", "ファイルディレクトリーエラー");
                return;
            }
            //インスタンス
            WebClient mywebClient = new WebClient();
                Console.WriteLine("LoadingFile from{0}...",mySavePath);
                //データ取得
                //OpenReadメソッドを使うことで、サーバ上に存在しないディレクトリは例外として返す
                Stream myStream = mywebClient.OpenRead(mySavePath);
                StreamReader sr = new StreamReader(myStream,Encoding.GetEncoding("Shift_JIS"));//エンコード変換
                Console.WriteLine("Loaded successfully. displayed the data in textbox.");
                //テキストボックスに情報を表示
                string tmp_txtt = sr.ReadToEnd();
                TextBox_fromFile.Text = tmp_txtt;
            
                sr.Close(); 

        }

        private void BtnDL_Img_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();
            cofd.Title = "フォルダを選択して下さい";
            //フォルダ選択モード
            cofd.IsFolderPicker= true;
            if (cofd.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            string DL_Path = cofd.FileName;
            //webclient()をインスタンス化
            System.Net.WebClient dl = new System.Net.WebClient();
            string remoteUri = "http://ponpon-english.com/backup_datas/Csharp/Data/";
            string fileName = "\\Kaime.csv";
            string myStringWebResource = remoteUri + fileName;
            mySavePath = DL_Path + fileName;
            try
            {
                Console.WriteLine("Downloading File {0} from {1} .......\n\n", mySavePath, myStringWebResource);
                dl.DownloadFile(myStringWebResource,mySavePath);
                Console.WriteLine(mySavePath);
                Console.WriteLine("Successfully Downloaded File {0} from {1}", mySavePath, myStringWebResource);
                dl.Dispose();
            }
            catch (WebException)
            {
                Console.WriteLine("指定されたアドレスが無効です");
                return;
            }
        }

        private void BtnFileLoad(object sender, EventArgs e)
        {

        }
    }
}

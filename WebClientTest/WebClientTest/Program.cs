
using System;
using System.Net;
using System.Text;

//エンコーダー設定(System.Text.Encoding.CodePagesをインストールしておく)
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

//Uri、フォルダ設定
string Uri = "http://ponpon-english.com/backup_datas/Csharp/Data/"; ;
string filePath = "Kaime.csv";
string myWebResource = Uri + filePath;
//インスタンス
WebClient myWebClient = new System.Net.WebClient();
Console.WriteLine("Loading File from...{0}", myWebResource);
//データ取得
Stream myStream = myWebClient.OpenRead(myWebResource);
StreamReader sr = new StreamReader(myStream, Encoding.GetEncoding("Shift_JIS"));
try
{
    string str_tmp = sr.ReadToEnd();

    //①内容表示
    Thread.Sleep(2000);
    Console.WriteLine("Loading has been finished.Loaded contents below:\n{0}", str_tmp);
    sr.Close();

    //②ファイル書き出し
    Console.WriteLine("creating files...");
    string LFilePath = Environment.CurrentDirectory + "\\test.txt";
    StreamWriter myStreamWriter = new StreamWriter(LFilePath);
    myStreamWriter.Write(str_tmp);
    myStreamWriter.Close();//クローズをすることで、書き出し処理を行う
    Thread.Sleep(2000);
    Console.WriteLine("file has been created successfully\n files in...{0}", LFilePath);
    //➂配列保存
    Console.WriteLine("\nstoraging datas....");
    List<string> txt = new List<string>();
    //行ごとに配列に格納する
    string[] txts = File.ReadAllLines(LFilePath);

    foreach (string t in txts)
    {
        txt.Add(t);
    }
    txt.RemoveAt(0);   
    Thread.Sleep(2000);
    Console.WriteLine("storaging has benn done.");
}

catch (Exception e)
{
    Console.WriteLine("error ocurred:{0}", e);
    return;
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Resources;
using System.Reflection.Emit;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace SatoLib
{
    public class library
    {
        //インスタンス（クラス内）変数領域

        //領域終わり
        //基本静的メソッドしか使わないし、一つひとつ取り出して使うライブラリなので記述しない。


        //フォルダ画像パス取得
        public static List<String> getTextFileList(string path)
        {
            List<String> files = new List<String>();
            try
            {
                string[] dirs = Directory.GetFiles(path, "*.txt");
                foreach (string dir in dirs)
                {
                    files.Add(dir);
                    Console.WriteLine(dir);
                }
            }
            catch (Exception e)
            {
            }
            return (files);//listとstring
        }


        //画像型でリスト取得(Maxは最大取得数)
        public static List<Image> getImageList(string filepath,int Max = 50)
        {
                //リスト初期化
                List<Image> imgList = new List<Image>();
                string[] dir_jpg = Directory.GetFiles(filepath, "*.jpg");
                string[] dir_png = Directory.GetFiles(filepath,"*.png");
                //配列をリストに格納
                List<string> pathlist = new List<string>();
                pathlist.AddRange(dir_jpg);//AddRangeによって、自動的にリスト型として追加している
                pathlist.AddRange(dir_png);
                int counter = 0;
                foreach (string path in pathlist)
                {
                try
                {
                    Image temp = Image.FromFile(path);
                    imgList.Add(temp);
                    counter++;
                    if (counter >= 50)
                        throw new Exception("画像最大到達エラー");
                }
                catch(Exception e) 
                {
                    Console.WriteLine($"画像の読み込みは{counter}ファイルで終了しました");
                    return imgList;
                }
                }
            return imgList;
        }

        //文字列型リストシャッフル
        public static List<string> shuffleStrList(List<string> list)
        {
            List<string> list_new = new List<string>();
            Random rdm = new Random();
            int list_length = list.Count;
            //ランダム理論（むずいので、とりあえず使いまわす)
            for (int i = 0; i < list_length; i++)
            {
                int indx = rdm.Next(0, list_length - i);
                string tmp = list[indx];
                //Console.Write(tmp);
                list_new.Add(tmp);
                list.RemoveAt(indx);
            }
            return list_new;
        }

        //画像型リストシャッフル
        public static List<Image> shuffleImgList(List<Image> list)
        {
            List<Image> list_new = new List<Image>();
            Random rdm = new Random();
            int list_length = list.Count;

            for (int i = 0; i < list_length; i++)
            {
                int indx = rdm.Next(0, list_length - i);
                Image tmp = list[indx];
                list_new.Add(tmp);
                list.RemoveAt(indx);
            }
            return list_new;
        }

        //タイマー
        public static void countTimer(int COUNT,CancellationToken token)
        {
            Console.WriteLine("timer start");
            Console.WriteLine(COUNT);
            for (int n = 1; n <= COUNT; n++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("キャンセルトークンが渡されました");
                    return;
                }
                Thread.Sleep(1000);
                int remain = COUNT - n;
                Console.WriteLine(remain);
            }
            Console.WriteLine("finish");
        }

        public static List<string> getCsvData_toList(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return null;
            }
            List<string> slist= new List<string>();
            StreamReader sr = new StreamReader(filepath,Encoding.GetEncoding("Shift-JIS"));
            while(sr.Peek() >= 0)
            {
                slist.Add(sr.ReadLine());
            }
            sr.Close();
            return slist;
        }

        public static bool is_TxtFile(string FilePath)
        {
            return (System.IO.Path.GetExtension(FilePath) == ".txt");
        }

        public static List<string> getStrList(string FilePath)
        {
                List<string> strList = new List<string>();
                StreamReader sr = new StreamReader(FilePath);
                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine();
                    strList.Add(str);
                }
                return strList;

        }

        //ファイルパス取得　※getfileでの戻り値はarr型
        public static List<string> getTextFPathList(string FPath)
        {
                List<string> TFlist = new List<string>();
                string[] FPathArr = Directory.GetFiles(FPath, "*.txt");
                TFlist.AddRange(FPathArr);

                return TFlist;
        }

    }
}





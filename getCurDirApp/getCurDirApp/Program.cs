// See https://aka.ms/new-console-template for more information

//今のところ２パターン

string curDir = System.IO.Directory.GetCurrentDirectory();
Console.WriteLine($"アプリ実行ディレクトリ:{ curDir}");
string curDir2 = Environment.CurrentDirectory;
Console.WriteLine($"アプリ実行ディレクトリ:{curDir2}");

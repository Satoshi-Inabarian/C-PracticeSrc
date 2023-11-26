// See https://aka.ms/new-console-template for more information

//Task.Run(() => メソッド());により、非同期処理ではなかった処理をまとめて、タスクを作り、別スレッドで実行する。
//重たい同期処理を非同期にしたい場合
//Thread.Sleepは、スレッド内の処理をフリーズ（寝る）させる処理
//
//https://qiita.com/inew/items/0126270bca99883605de
//その際に使用できるのが、await/asyncである。 https://qiita.com/rawr/items/5d49960a4e4d3823722f


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



//Taskで新しいスレッドを起動し、３秒、５秒起きにアナウンスを行い、２０秒たったら★★★が現れる。
//実行ソース//

main();

//おわり//










//メソッド
void main()
{
    count_Announce();
}


//１⃣非同期マルチ処理（戻り値がない場合)
void count_Announce()
{
    //var leisure_hour = GetLeisureHoursAsync().Result;
    int cnt_max = 20;
    Task.Run(() => count(cnt_max));
    Task.Run(() => Announce3s(cnt_max));
    Task.Run(() => Announce5s(cnt_max));
    //このように表記すれば、戻り値が取得するまでforloopをぬけても、Task.runは実行されつづけるらしい・・なぜかは現状わからない。
    Console.WriteLine(GetLeisureHoursAsync().Result);

}

//２⃣非同期（戻り値がある場合)　
//難しい・・・
//これらを読んで解決する→https://learn.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/async/async-return-types　これ読む
                           //https://qiita.com/inew/items/0126270bca99883605de
                            //https://learn.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/async/async-return-types


static async Task<string> GetLeisureHoursAsync()
{
    Console.WriteLine("after 20s, will be stars on windows...");
    Thread.Sleep(20000);
    string stars= "★★★";
    return stars;
}



void count(int max)
{
    Console.WriteLine("Count Start!");
    int num = 1;    
    for (int i = 1; i <= max; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine(num + "seconds");
        num = num + 1;
    }
}
void Announce3s(int max)
{
    int num = 3;
    for (int n = 1;n<max; n++)
    {
        Thread.Sleep(3000);
        Console.WriteLine(num + "秒経過しました");
        num = num + 3;
    }
    Console.WriteLine("３秒カウント終了");
    return;
}

void Announce5s(int max)
{
    int num = 5;
    for (int n = 1; n <= max; n++)
    {
        Thread.Sleep(5000);
        Console.WriteLine(num + "秒経過しました。");
        num = num + 5;
    }
    Console.WriteLine("５秒カウント終了");
    return;
}

StartTask();
Console.ReadKey();
void StartTask()
{
    // キャンセルトークンソースを生成し、キャンセルトークンを取得します。
    var tokenSource = new CancellationTokenSource();
    var token = tokenSource.Token;

    // タスクにキャンセルトークンを渡し、タスクを開始します。
    Task.Run(() => MyAction(token));

    var c = Console.ReadKey();
    //タスクキャンセル条件
    if (c.Key == ConsoleKey.Enter)
    {
        // タスクをキャンセルします
        Console.WriteLine("Cancel");
        tokenSource.Cancel();
    }
}

/**
 * @brief タスクの処理
 * 
 * @param [in] token キャンセルトークン
 */
void MyAction(CancellationToken token)
{
    Console.WriteLine("MyAction start.");

    // キャンセルされるまで繰り返します。
    var counter = 0;
    while (true)
    {
        Console.WriteLine($"counter={++counter}");

        Thread.Sleep(100);

        // キャンセルされた場合
        if (token.IsCancellationRequested)
        {
            // ループを終了します。
            break;
        }
    }
}
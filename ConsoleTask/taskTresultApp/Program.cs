

//メインソース
var getLeisureHoursTask = GetLeisureHoursAsync();

await getLeisureHoursTask;
Console.WriteLine(getLeisureHoursTask.Result);

static Task<string> GetLeisureHoursAsync()
{
    Thread.Sleep(3000);
    str str = "3s passed";
    return str;
}



// Example output:
//    Today is Wednesday, May 24, 2017
//    Today's hours of leisure: 5
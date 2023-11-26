class Employee
{
    //class内 メンバー変数（初期値設定ともとれる）
    private readonly string _name = "山田, 太郎";
    private readonly double _salary = 10000.0;

    public string GetName()
    {
        return _name;
    }

    public double Salary
    {
        get { return _salary; }
    }
}

class PrivateTest
{
    static void Main()
    {
        //インスタンス化
        var id1 = new Employee();

        string name = id1.GetName();
        Console.WriteLine(name);
        // '_salary' is indirectly accessed via property
        double sal = id1.Salary;
        Console.WriteLine($"給料{sal}円");
    }
}
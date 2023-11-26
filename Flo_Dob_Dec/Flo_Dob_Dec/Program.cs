// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//★型の違いによる計算処理結果の違い★//
//float(4バイト浮動小数点型) = 32ビット
//double(8バイト浮動小数点型)= 64ビット
int a = 2;
double b = 2.125d;
float c = 3.2346f;
decimal d = 2.125m;


//1.double + float = double
double res1 = b + c;
Console.WriteLine($"double + float = double:{res1}");
//floatは、doubleに自動的に型変換を行うことができる。
//結果に誤差が生じる

//2. double + float = float
float res3 = Convert.ToInt32(b) + c;
Console.WriteLine($"double + float=float{res3}");
//double→floatは、int32ビット型に変換を行う必要がある。
//結果にかなり誤差が生じる

//3. double + decimal = decimal
decimal res2 = Convert.ToDecimal(b) + d;
Console.WriteLine($"double+decimal = decimal{res2}");
//doubleをdecimalに型変換を行うことで、計算できる。

//3. double + decimal = double
double res6 = b + Convert.ToDouble(d);
Console.WriteLine($"double+decimal = double{res6}");
//doubleをdecimalに型変換を行うことで、計算できる。

//4. double + int = double
double res4 = a + b;
Console.WriteLine($"double+int= double{res4}");

//5. decimal + int = int
decimal res5 = a + d;
Console.WriteLine($"decimal+int= double{res5}");
//

//★★考察★★//
//1.計算結果に精度が必要な場合はdecimalを使う
//2.処理速度＞精度の場合は、基本的にdoubleを使用する。
//3.floatとdoubleをむやみに型変換すると、誤差が生じる。
//4.整数・小数点計算は、結果をdouble、decimalに変換して行う
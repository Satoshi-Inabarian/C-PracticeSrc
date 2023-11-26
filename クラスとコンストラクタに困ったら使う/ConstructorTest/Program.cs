using ClassConstructor;

//名前と給料を表示するクラス
//メンバ変数 public string _name = "はじめ太郎"; 名前
//           public int    _salaly; 給料

//１⃣引数つきのコンストラクタ(string _name, int _salaly)
//２⃣引数なしのコンストラクタ
//初期値　this._name ="名無し太郎";
//        this._salaly = 0;

//　二つのメソッド
// string name = getName()
// iint salaly = getSlaly()


//１⃣引数なしのコンストラクタを使用してインスタンスを
Test test1 = new Test();
//実行
Console.WriteLine(test1._name);
Console.WriteLine(test1._salaly);
string n1 = test1.GetName();
double s1 = test1.GetSalaly();
//メンバ変数参照
Console.WriteLine($"インスタンス変数{test1._name}さんの給料{test1._salaly}円です");
//test1メソッド戻り値参照
Console.WriteLine($"メソッド戻り値:{n1}さんの給料{s1}円です");
//結果 名無し太郎さんの給料は0円です。

//考察 メンバ変数の初期値設定(はじめ太郎)よりも、コンストラクタ内初期化メソッドが優先されるようだ。

//２⃣引数ありのコンストラクタを使用
Test test2 = new Test("佐藤花子", 700);

//実行
double s2 = test2.GetSalaly();
string n2 = test2.GetName();

Console.WriteLine($"インスタンス変数:{test2._name}さんの給料{test2._salaly}円です");
Console.WriteLine($"メソッド戻り値:{n2}さんの給料{s2}円です");
//result 佐藤花子さんの給料は700円です。
//考察 引数をいれると、引数ありのコンストラクタが使用され、クラス内で変数として使用される。



//３⃣引数ありのコンストラクタを使用して、メンバ変数に直接値をいれる。
//どちらの値がインスタンス生成時に優先されるのか。

//引数設定
Test test3 = new Test("鈴木一郎", 1000);

//メンバ変数（インスタンス変数）の変更
test3._name = "上書き一郎";

double s3 = test3.GetSalaly();
string n3 = test3.GetName();
Console.WriteLine($"インスタンス変数:{test3._name}さんの給料{test3._salaly}円です");
Console.WriteLine($"メソッド戻り値:{n3}さんの給料{s3}円です");
//result 上書き一郎さんの給料は700円です。
//考察 コンストラクタに引数をいれたとしても、そのあとに書き加えれば変更を行うことができる。



//まとめ
//1.外から使用するライブラリにはpublicでグローバル宣言を行う。メソッドも同様である。
//1.メンバ変数の設定は型宣言において、必須である。
//2.メンバ変数には、初期設定を行うことができるが、コンストラクタメソッドを使用する場合は必須ではない。
//3.コンストラクタメソッドには引数を使用するコンストラクタと、引数を必要としないコンストラクタがある。
//4.クラス内のある特定のメソッドだけを使いたい場合は、引数なしを使用すると、効率的である。
//5.引数コンストラクタによってインスタンス生成後直後に、メンバ変数に値を直接いれるとを行うと、そちらが優先される。
//6.外部からdllファイルを通してクラスを呼び出す場合は、原則class、メソッド、及びメンバ変数全てにpublicをつけること。
//7.メンバ変数にpublicを使用せずともクラスは使用できるが、プロパティで呼び出せなくなる。
    
        //※例 Test test4 = new Test("佐藤一郎",100,000)
        //     test4._name このプロパティ参照できなくなる。


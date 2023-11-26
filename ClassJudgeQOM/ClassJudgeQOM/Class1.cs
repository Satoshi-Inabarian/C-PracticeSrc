using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//JudgeMeat 
//1.スコア = 肉スコア計算メソッド(消費期限までの日時、色、国産か海外か)
//2.Excent,good,normal = 質判断メソッド


//
namespace ClassJudgeQOM
{
    public class JudgeMeat
    {

        //メンバ変数
        public string _MeatName = null; //肉名前
        public int _UntilExpire; //消費期限まで日時
        public string _Color; //色
        public bool _Domestic; //国内産フラグ　true =国内産 false =国外産



        //コンストラクタ(引数あり)
        public JudgeMeat(string _MeatName, int _UntilExpire, string _Color, bool _Domestic)
        {
            this._MeatName = _MeatName;
            this._UntilExpire = _UntilExpire;
            this._Color = _Color;
            this._Domestic = _Domestic;
        }


        public int Cal()
        {
            int Mscore =0;
            try// try catch型https://www.sejuku.net/blog/55579
            {
                //消費期限
                if (_UntilExpire > 5)
                    {
                    Mscore += 2;
                    }
                else if (_UntilExpire > 3)
                    {
                    Mscore++;
                    }
                //肉の色
                if (_Color == "red")
                {
                    Mscore += 2;
                }
                else if (_Color == "orange")
                {
                    Mscore++;
                }
                else if (_Color =="blue")
                {
                    Mscore -= 2;
                }
                else
                {
                    throw new Exception("色指定エラー発生");
                }
                //国内産判定
                if (_Domestic)
                {
                    Mscore += 2;
                }
                else
                {
                    Mscore++;
                }
                               
            }
            catch(Exception e)
            {
                Mscore = -10;
                return Mscore;
            }
        finally
            {

            }
         
            return Mscore;
        }

        public void EvaluateMeat(int score)
        {
            string result = null;
            try
            {
            if (score > 5)
            {
                result = "Excelent";
            }
            else if (score > 3)
            {
                result = "Good";
            }
            else if (score > 1)
            {
                result = "normal";
            }
            else if (score > -2)
            {
                result = "bad";
            }
            else
                {
                    throw new Exception("InputError");
                }
            Console.WriteLine($"{_MeatName} Quality:【{result}】");
            }
            catch(Exception e) when(e.Message.Equals("InputError"))
            {
                Console.WriteLine("入力された数値が正しくないか、入力されていません。以下参照");
                Console.WriteLine($"1.string Name \n2.int UntilExpireDay\n3.string Color[red,orange,blue]\n4.DomesticFlag bool True or False");
            }
          
        }

       
    }
}

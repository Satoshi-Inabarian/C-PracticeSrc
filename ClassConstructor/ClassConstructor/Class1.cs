using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructor
{
    public class Test
    {
        //class内 メンバー変数（初期値設定ともとれる）
        public string _name = "はじめ太郎"; //
        public double _salaly;

        //コンストラクタ(初期化メソッド)
        public Test(string _name, double _salaly)
        {
            this._name = _name; //thisはインスタンス作成時に格納される特別な変数
            this._salaly = _salaly;
        }

        //引数なしのコンストラクタ
        public Test()
        {
            this._name = "名無し太郎";
            this._salaly = 0;
        }

        public string GetName()
        {
            return _name;
        }
        public double GetSalaly()
        {
            return _salaly;
        }



    }
}


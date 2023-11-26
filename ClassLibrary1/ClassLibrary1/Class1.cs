using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatoLib;

namespace ClassLibrary1
{
    public class TestClass
    {

        private int _num;
        private string _str;

        public TestClass(int num,string str)
        { 
            _num = num;
            _str = str;
            Console.WriteLine("インスタンス作成");
        }


        public string getProperty()
        {
            return _str;
        }


        public int getProperty_num()
        {
            return _num;
        }

        public List<string> getList(string filepath)
        {
            List<string> list = library.getStrList(filepath);
            return list;
        }
    }
}

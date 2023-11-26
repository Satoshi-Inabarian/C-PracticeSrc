using SatoLib;

namespace ClassLibrary2
{
    public class TestClass2
    {

        private int _num;
        private string _str;

        public TestClass2(int num, string str)
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
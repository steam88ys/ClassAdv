using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            // 소멸자 실습
            Product product1 = new Product("과자", 1000);
            Product product2 = new Product("빼빼로", 2000);
            Product product3 = new Product("닭꼬치", 3000);
            Product product4 = new Product("탕후루", 4000);

            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
        }
    }
}

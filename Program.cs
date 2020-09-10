using System;
using System.Text;

namespace tienlaichovay
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập số tiền gửi: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng gửi: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lãi suất:");
            
            intersetRate = Double.Parse(Console.ReadLine());
            tienlaichovay(money, month, intersetRate);
            Console.WriteLine("Lãi suất nhận được: {0}", tienlaichovay(money, month, intersetRate));
        }

        private static double tienlaichovay(double money, int month, double intersetRate)
        {
            double tienlai = 0;
            for (int i = 0; i < month; i++)
            
                tienlai = money * (intersetRate / 100) / 12 * 3;
            
            return tienlai;
        }
    }
}

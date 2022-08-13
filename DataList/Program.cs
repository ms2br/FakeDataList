using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAdd Login = new DataAdd();
            Login.DataListAdd();
            Personel Info = new Personel();
            ErrorControlClass MyError = new ErrorControlClass();
            ConsoleWrite write = new ConsoleWrite();
            for (int number = 0; number != 4;)
            {
                Console.Clear();
                Console.WriteLine("1.Kayit Olusturma");
                Console.WriteLine("2.Kayit Duzenleme");
                Console.WriteLine("3.Kayit Silme");
                Console.WriteLine("4.Cikis");
                Console.Write("Secim : ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (number == 1)
                {
                    Login.ComeDataListAdd();
                }
                else if (number == 2)
                {
                    Console.Clear();
                    try
                    {
                        write.NamesInfo();
                        Console.Write("Indexi Giriniz : ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        write.AllInfo(index);
                    }
                    catch (FormatException Fx)
                    {
                        Console.WriteLine("Int Turunde Deger Giriniz : ");
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex.Message);
                    }
                }else
                {
                    break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataList
{
    internal class DataAdd
    {
        public static List<Personel> AllData;
        public static List<string> NameData;
        static DataAdd()
        {
            AllData = new List<Personel>();
            NameData = new List<string>();
        }

        public void DataListAdd()
        {
            for (int i = 0, counter = 0; i < 100; i++)
            {
                Personel Info = new Personel();
                Info.Isim = FakeData.NameData.GetFirstName();
                Info.SoyIsim = FakeData.NameData.GetSurname();
                string name = $"{Info.SoyIsim} {Info.Isim}";
                Info.Id = ++counter;
                Info.Ulke = FakeData.PlaceData.GetCountry();
                Info.Il = FakeData.PlaceData.GetCity();
                Info.Ilce = FakeData.PlaceData.GetCounty();
                Info.FirmaAdi = FakeData.NetworkData.GetDomain();
                Info.PersonleInfo[0].MobilNumara = FakeData.PhoneNumberData.GetPhoneNumber();
                Info.PersonleInfo[0].SabitHat = FakeData.PhoneNumberData.GetInternationalPhoneNumber();
                Info.PersonleInfo[0].emaiLAdress = $"{Info.Isim}{Info.SoyIsim}@.{Info.FirmaAdi}";
                AllData.Add(Info);
                NameData.Add(name);
            }
        }

        public List<Personel> ComeDataListAdd()
        {
            Personel Data = new Personel();
            ErrorControlClass MyError = new ErrorControlClass();
            try
            {
                Console.Write("Personel ID Giriniz : ");
                Data.Id = Convert.ToInt32(Console.ReadLine());
                if (!MyError.ErrorControlMetot(Data.Id))
                    throw new ErrorControlClass();
                Console.Write("Personel Ismi : ");
                Data.Isim = Console.ReadLine();
                Console.Write("Personel SoyIsmi : ");
                Data.SoyIsim = Console.ReadLine();
                Console.Write("Ulke Ismi :  ");
                Data.Ulke = Console.ReadLine();
                Console.Write("Il Ismi : ");
                Data.Il = Console.ReadLine();
                Console.Write("Ilce Ismi : ");
                Data.Ilce = Console.ReadLine();
                Console.Write("Firma Ismi : ");
                Data.FirmaAdi = Console.ReadLine();
                string end = String.Empty;
                for (int i = 0; end!="E" ;i++)
                {
                    Data.PersonleInfo.Add(new PersonelIletisimBilgileri());
                    Console.Write("Personel EmailAdressi Giriniz : ");
                    Data.PersonleInfo[i].emaiLAdress = Console.ReadLine();
                    Console.Write("Personel Mobil Numarsi Giriniz : ");
                    Data.PersonleInfo[i].MobilNumara = Console.ReadLine();
                    Console.Write("Personel Sabit Hati : ");
                    Data.PersonleInfo[i].SabitHat = Console.ReadLine();
                    Console.Write("Personel Iletisim Bilgileri Sonlandirmak Icin (E/H) : ");
                    end = Console.ReadLine().ToUpper();
                    if (end == "E")
                        break;
                }
                string Name = $"{Data.SoyIsim} {Data.Isim}";
                NameData.Add(Name);
                AllData.Add(Data);
            }
            catch (FormatException FE)
            {
                Console.Clear();
                Console.WriteLine("Girilen Deger Dogru Formatta Degil.");
            }
            catch (ErrorControlClass)
            {
                Console.Clear();
                Console.WriteLine("Bu ID Dahha Onceden Girilmisdir.....");
            }
            catch (Exception E)
            {
                Console.Clear();
                Console.WriteLine(E.Message);
            }
            Console.Clear();            
            return AllData;
        }
    }
}
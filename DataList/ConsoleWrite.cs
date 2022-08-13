using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataList
{
    internal class ConsoleWrite
    {
        List<Personel> AllList;
        List<string> NameList = new List<string>();
        public void NamesInfo()
        {
            int counter = 0;
            NameList = DataAdd.NameData;
            NameList.ForEach(i => Console.WriteLine($"{++counter}. {i}"));
        }

        public void AllInfo(int counter)
        {
            Console.Clear();
            if (DataAdd.AllData.Count >= counter)
            {
                AllList = new List<Personel>();
                AllList.Add(DataAdd.AllData[--counter]);
                AllList.ForEach(i => Console.WriteLine($"Personel ID : {i.Id}"));
                AllList.ForEach(i => Console.WriteLine($"Personel Ismi : {i.Isim}"));
                AllList.ForEach(i => Console.WriteLine($"Personel SoyIsmi : {i.SoyIsim}"));
                AllList.ForEach(i => Console.WriteLine($"Ulke Ismi : {i.Ulke}"));
                AllList.ForEach(i => Console.WriteLine($"Il Ismi : {i.Il}"));
                AllList.ForEach(i => Console.WriteLine($"Ilce Ismi : {i.Ilce}"));
                AllList.ForEach(i => Console.WriteLine($"Firma Ismi : {i.FirmaAdi}"));
                for (int i = 0; i < AllList.Sum(count => count.PersonleInfo.Count) ; i++)
                {
                    AllList.ForEach(index => Console.WriteLine($"EmailAdress  : {index.PersonleInfo[i].emaiLAdress}"));
                    AllList.ForEach(index => Console.WriteLine($"Mobil Numara : {index.PersonleInfo[i].MobilNumara}"));
                    AllList.ForEach(index => Console.WriteLine($"Sabit Hat  : {index.PersonleInfo[i].SabitHat}"));
                }
            }
            else
            {
                Console.WriteLine("Girdiniz Deger Bulunamadi");
            }
        }
    }
}

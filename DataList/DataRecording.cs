using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataList
{
    internal class DataRecording
    {
        List<Personel> AllList = new List<Personel>();
        List<string> Name = new List<string>();

        public int voteMetot(int values = 0)
        {
            AllList = DataAdd.AllData;
            DataRecording Recording = new DataRecording();
            if (values == 2)
                Recording.InfoOrder(0);
            else if (values == 3)
                Recording.InfoDelete(0);
            return values;


        }

        public void InfoOrder(int index)
        {
            ConsoleWrite write = new ConsoleWrite();
            write.AllInfo(index);
            Personel PersoInfo = AllList[--index];
            Program values = new Program();

            #region
            /*AllList.Add(DataAdd.AllData[--index]);
            AllList.ForEach(i => Console.Write($"Personel ID : {i.Id}"));
            AllList.ForEach(i => Console.Write($"Personel Ismi : {i.Isim}"));
            AllList.ForEach(i => Console.Write($"Personel SoyIsmi : {i.SoyIsim}"));
            AllList.ForEach(i => Console.Write($"Ulke Ismi : {i.Ulke}"));
            AllList.ForEach(i => Console.Write($"Il Ismi : {i.Il}"));
            AllList.ForEach(i => Console.Write($"Ilce Ismi : {i.Ilce}"));
            AllList.ForEach(i => Console.Write($"Firma Ismi : {i.FirmaAdi}"));
            for (int i = 0; i < AllList.Count; i++)
            {
                AllList.ForEach(counter => Console.Write($"EmailAdress  : {counter.PersonleInfo[i].emaiLAdress}"));
                AllList.ForEach(counter => Console.Write($"Mobil Numara : {counter.PersonleInfo[i].MobilNumara}"));
                AllList.ForEach(counter => Console.Write($"Sabit Hat  : {counter.PersonleInfo[i].SabitHat}"));
            }*/
            #endregion
        }

        public void InfoDelete(int index)
        {

        }


    }
}

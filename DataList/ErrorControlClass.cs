using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataList
{
    internal class ErrorControlClass : Exception
    {
        List<Personel> List = new List<Personel>();
        public bool ErrorControlMetot(int ID)
        {
            List = DataAdd.AllData;
            if (List.Any(i => i.Id == ID))
                return false;
            else
                return true;
        }
    }
}

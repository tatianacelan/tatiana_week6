using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_provavenerdi
{
   public  interface IManagerAgentePolizia<T>
    {
        public List<T> StampaTutti();
        public T CercaConArea(string area);
   
        public bool Aggiungi(T item);
        public List<T> StampaPerAnniServizio(int anniServizio);
    }
}

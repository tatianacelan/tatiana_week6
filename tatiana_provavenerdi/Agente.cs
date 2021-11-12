using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_provavenerdi
{
    class Agente:Persona 

    {
        public string  AreaGeografica  { get; set; }
        public DateTime AnnoInizioAttivita { get; set;  }
        public Agente()
        { }
        public Agente(string cf, string nome, string cognome, string area, DateTime annoinizio)
            : base(cf, nome ,cognome)
        {
            AreaGeografica = area;
            AnnoInizioAttivita = annoinizio; 
        }
        public override string ToString()
        {
            return $"CF:{CF} -Nome: {Nome}  Cognome: {Cognome}-Anni di servizio:{DateTime.Now.Year - AnnoInizioAttivita.Year}";
        }
     
    }
}

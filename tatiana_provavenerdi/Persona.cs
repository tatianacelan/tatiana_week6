using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_provavenerdi
{
  public abstract class Persona
    {
        public string CF { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Persona()
        { 
        }
        public Persona(string cf, string nome, string cognome)
        {
            CF = cf;
            Nome = nome;
            Cognome = cognome;
        }
        public override string ToString()
        {
            return $"CF: {CF}- Nome: {Nome} Cognome:{Cognome} ";
        }

    }
}

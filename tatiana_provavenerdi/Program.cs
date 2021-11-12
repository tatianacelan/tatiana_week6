using System;
using System.Collections.Generic;

namespace tatiana_provavenerdi
{
    class Program

    {

        // risposte a domande multiple: 
        // 1.a, e, g 
        //2. b,d
        //3.c


        private static DBManagerAgentePolizia db = new DBManagerAgentePolizia();
        static void Main(string[] args)
        {
            Console.WriteLine("Agente di polizia!");
            Console.WriteLine("Alt!Servizio di controllo sicurezza");
            bool continua = true;
            while (continua)
            {
                Console.WriteLine("--------------------------------Menu----------------------------");
                Console.WriteLine("Premi 1 per vedere tutti gli agenti");
                Console.WriteLine("Premi 2 per vedere gli agenti assegnati ad una certa area");
                Console.WriteLine("Premi 3 per vedere gli agenti che superanno  un tot anni di servizio ");
                Console.WriteLine("Premi 4 per inserire un nuovo agente ");

                Console.WriteLine("0. Exit");


                int scelta;
                do
                {
                    Console.WriteLine("Scegli cosa fare!");
                } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 4));

                switch (scelta)
                {
                    case 1:
                    
                        VisualizzaTuttiAgenti();
                        break; 
                    case 2:
                        VisualizzaAgentiPerAreaAssegnata();
                        break;  
                    case 3:
                        //agenti  che superano un tot anni di servizio 
                        VisualizzaAgentiPerAnniServizio();
                        break;  
                    case 4:
                        InserisciNuovoAgente();
                      
                        break;  
                    case 0:
                        Console.WriteLine("Alla prossima!");
                        continua = false; 
                        break;
                }
            }
        }

        private static void VisualizzaAgentiPerAnniServizio()
        {
            Console.WriteLine("Inserisci durata. ti verrano restituiti quelli con piu anni di servizio.");

            int anniServizio;
            while (!(int.TryParse(Console.ReadLine(), out anniServizio) && anniServizio > 0))
            {
                Console.WriteLine("Valore errato. riprova!");
            }
            Console.WriteLine("Ecco la lista:");
           var agentiServizio= db.StampaPerAnniServizio(anniServizio);
        
            foreach (var item in agentiServizio)
            {
                Console.WriteLine($" {item.ToString()}");
            }
        }

        private static void InserisciNuovoAgente()
        {
            string cf;
            bool esistenza = false;
            do
            {
                Console.WriteLine("Inserisci cod fiscale ");
                 cf = Console.ReadLine();
                 esistenza = EsisteCodiceFiscale(cf);
           

            }
            while (esistenza);

                Console.WriteLine("Inserisci nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci cognome ");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci area di servizio del agente");
            string areaGeo = Console.ReadLine();

            Console.WriteLine("Inserisci data e anno  inizio servizio ");
            DateTime data =DateTime.Parse( Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Il nuovo agente da te inserito e: \n" +
                $"CF:{cf}-Nome:{nome} Cognome:{cognome} Area servizio: {areaGeo}, data inizio:{data}");

            var nuovoAgente = new Agente(cf, nome, cognome, areaGeo, data);
            bool esito = db.Aggiungi(nuovoAgente);
            if (esito)
            {
                Console.WriteLine();
                Console.WriteLine("Aggiunto correttamente");
            }
            else
            {
                Console.WriteLine("Errore. Non è stato possibile aggiungere!");
            }
            
        }

        private static void VisualizzaAgentiPerAreaAssegnata()
        {
            Console.WriteLine("Inserisci area geografica da ricercare:");
            string areaRicercare = Console.ReadLine();
            var ag= db.CercaConArea(areaRicercare);
        
            List <Agente> agenti = new List<Agente>();
           agenti.Add(ag);
         
            Console.WriteLine($"Questi sono gli agenti di {areaRicercare}:");
            foreach (var item in agenti)
            {
                Console.WriteLine(item);
            }
        }

        private static void VisualizzaTuttiAgenti()
        {
            Console.WriteLine("La lista di tutti gli agenti :\n");
            var agentiPolizia = db.StampaTutti();
            int elenca = 1;
            foreach (var item in agentiPolizia)
            {
                Console.WriteLine($"{elenca++}. {item.ToString()}");
            }
        }

        private static bool EsisteCodiceFiscale( string cf)
        {
     
            var agenti = db.StampaTutti();
            foreach (var item in agenti)
            {
                if (item.CF == cf)
                {
                    return true ; 

                }
            }
            return false;

        }
    }
}

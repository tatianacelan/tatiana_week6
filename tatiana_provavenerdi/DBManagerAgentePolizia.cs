using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_provavenerdi
{
    class DBManagerAgentePolizia : IManagerAgentePolizia<Agente>
    {
        string cString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProvaAgenti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool Aggiungi(Agente item)
        {
            using (SqlConnection connection = new SqlConnection(cString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into AgentePolizia values(@CF, @Nome, @Cognome, @AreaGeografica, @Anno)";
                command.Parameters.AddWithValue("@CF", item.CF);
                command.Parameters.AddWithValue("@Nome", item.Nome);
                command.Parameters.AddWithValue("@Cognome", item.Cognome);
                command.Parameters.AddWithValue("@AreaGeografica", item.AreaGeografica);
                command.Parameters.AddWithValue("@Anno", item.AnnoInizioAttivita);

                int numRighe = command.ExecuteNonQuery();
                if (numRighe == 1)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;

            }
        }

        public List<Agente> StampaTutti()
        {
            using (SqlConnection connection = new SqlConnection(cString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from AgentePolizia";

                SqlDataReader reader = command.ExecuteReader();

                List<Agente> agentiPolizia = new List<Agente>();

                while (reader.Read())
                {
                    string cf = (string)reader["CF"];
                    string nome = (string)reader["Nome"];
                    string cognome = (string)reader["Cognome"];
                    string area = (string)reader["AreaGeografica"];
                    DateTime annoinizio = (DateTime)reader["AnnoInizioAttivita"];

                    Agente agente = new Agente(cf, nome, cognome, area, annoinizio);
                    agentiPolizia.Add(agente);
                }
                connection.Close();
                return agentiPolizia;
            }
        }

        public List<Agente> StampaPerAnniServizio(int anniServizio)
        {
         
            using (SqlConnection connection = new SqlConnection(cString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "select * from AgentePolizia where datepart(year, Current_timestamp)-datepart(year,AnnoInizioAttivita)>=@anno ";
                command.Parameters.AddWithValue("@anno", anniServizio);


                SqlDataReader reader = command.ExecuteReader();
                List<Agente> agenti = new List<Agente>();
                while (reader.Read())
                {
                    string cf = (string)reader["CF"];
                    string nome = (string)reader["Nome"];
                    string cognome = (string)reader["Cognome"];
                    string area = (string)reader["AreaGeografica"];
                    DateTime annoinizio = (DateTime)reader["AnnoInizioAttivita"];

                  Agente agente = new Agente(cf, nome, cognome, area, annoinizio);
                  agenti.Add(agente);
                }

                connection.Close();
               return agenti;
            }
        }

            public Agente CercaConArea(string areaInserita)
        {
            using (SqlConnection connection = new SqlConnection(cString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from AgentePolizia where AreaGeografica = @area";
                command.Parameters.AddWithValue("@area", areaInserita);

                SqlDataReader reader = command.ExecuteReader();

                Agente agenteArea = null;
                while (reader.Read())
                {
                    string cf = (string)reader["CF"];
                    string nome = (string)reader["Nome"];
                    string cognome = (string)reader["Cognome"];
                    string area = (string)reader["AreaGeografica"];
                    DateTime annoinizio = (DateTime)reader["AnnoInizioAttivita"];

                    agenteArea = new Agente(cf, nome, cognome, area, annoinizio);

                }
                connection.Close();
                return agenteArea;
            }
        
        }
        public void StampaArea()
        {
            using (SqlConnection connection = new SqlConnection(cString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from AgentePolizia";

                SqlDataReader reader = command.ExecuteReader();
                //string Area;
                //List<Task > tutteAree = new List<Task>();
                //while (reader.Read())
                //{ 

                //    string cf = (string)reader["CF"];
                //    string nome = (string)reader["Nome"];
                //    string cognome = (string)reader["Cognome"];
                //    string area = (string)reader["AreaGeografica"];
                //    DateTime annoinizio = (DateTime)reader["AnnoInizioAttivita"];
                //  Task tutteAree = new Task( area);
                //    tutteAree.Add(area);
                }
               // connection.Close();
            }
        //public bool ControlloUnicitaCodFiscale( List <Agente> agenti , string cod)
        //{  
        //    foreach (var item in agenti)
        //    { 
        //        if ( agenti)

        //    }
        //}

    }
}

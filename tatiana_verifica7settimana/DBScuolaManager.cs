using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_verifica7settimana
{
    public class DBScuolaManager
    {
    
      
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestioneScuola;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    

        public List<Studente> GetAllStudents()
        {
         
                using (SqlConnection connection = new SqlConnection(connectionString))        
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select * from Studente";

                    SqlDataReader reader = command.ExecuteReader();

                    List<Studente> studenti = new List<Studente>();
                    while (reader.Read())
                    {
                        int id = (int)reader["IdStudente"];
                        string nome = (string)reader["Nome"];
                        string cognome = (string)reader["Cognome"];

                        DateTime data = (DateTime)reader["DataNascita"];
                        int classe = (int)reader["IdClasse"];


                        Studente nuovoStudente = new Studente(id, nome, cognome, data, classe);
                        studenti.Add(nuovoStudente);

                    }
                    connection.Close();
                    return studenti;

                }
            
         


        }
    }
    
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_verifica7settimana
{
   public class Studente
    {
        private int id;
        private DateTime data;
        private int classe;

        public int IdStudente { get; set; }
        public string  Nome { get; set; }
        public string  Cognome { get; set; }
        public DateTime DataNascita { get; set;  }
        public int IdClasse { get; set;  }
        public Studente()
        { }

        public Studente(int id, string nome, string cognome, DateTime data, int classe)
        {
            IdStudente= id;
            Nome = nome;
            Cognome = cognome;
            DataNascita= data;
            IdClasse= classe;
        }

        public override string ToString()
        {
            return $"-Nome: {Nome}  Cognome: {Cognome} Classe: {IdClasse} ";
             
        }
    }

}

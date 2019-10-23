using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteHostApi.Model
{
    public class Cliente
    {
        private int id = 0;
        public int Id {
            get { return id; }
            set { id = value; }
        }

        private string nome = string.Empty;
        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade = 0;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private string email = string.Empty;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }



    }
}

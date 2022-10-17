using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp
{
    class Contato
    {
        private string nome, email, tel;
        public Contato(string n, string e, string f)
        {
            nome = n;
            email = e;
            tel = f;
        }
        public override string ToString()
        {
            return $"{nome}, {email}, {tel}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna_Final
{
    public class Candidato
    {
        string nome;
        string partido;
        string digitos;
        string url;
        int votos;
        int type;


        public Candidato(string nome,string digitos ,string part , string url, int type)
        {
            this.nome = nome;
            this.partido = part;
            this.digitos = digitos;
            this.url = url;
            this.votos = 0;
            this.type = type;
        }

        public string getNome()
        {
            return nome;
        }

        public string getPart()
        {
            return partido;
        }

        public string getDigitos()
        {
            return digitos;
        }
        public string getUrl()
        {
            return url;
        }

        public int getVotos() {

            return votos;
        }

        public void IncrementaVoto()
        {
            this.votos += 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna_Final
{
    public class Voto
    {
        private List<Candidato> lista_candidatos = new List<Candidato>();

        private int votosnulosDepFed = 0;
        private int votosnulosDepEst = 0;
        private int votosnulosSen = 0;
        private int votosnulosGov = 0;
        private int votosnulosPres = 0;
        private int votosbrancosDepFed = 0;
        private int votosbrancosDepEst = 0;
        private int votosbrancosSen = 0;
        private int votosbrancosGov = 0;
        private int votosbrancosPres = 0;


        public Candidato PesquisarDigitos(string digitos)
        {

            foreach (Candidato candidato in lista_candidatos)
            {
                if (String.Compare(candidato.getDigitos(), digitos, true) == 0)
                {
                    return candidato;
                }
            }
    
            return null;
        }

        public void incrementaNulo(int tipo)
        {
            if(tipo == 1)  votosnulosDepFed += 1;
            if(tipo == 2) votosnulosDepEst += 1;
            if(tipo == 3) votosnulosSen += 1;
            if(tipo == 4) votosnulosGov += 1;
            if(tipo == 5) votosnulosPres += 1;
        }

        public void incrementaBranco(int tipo)
        {
            if (tipo == 1) votosbrancosDepFed += 1;
            if (tipo == 2) votosbrancosDepEst += 1;
            if (tipo == 3) votosbrancosSen += 1;
            if (tipo == 4) votosbrancosGov += 1;
            if (tipo == 5) votosbrancosPres += 1;
        }

        public int getVotonulodepfed() { return votosnulosDepFed; }

        public int getVotonulodepest() { return votosnulosDepEst; }

        public int getVotonulosen() { return votosnulosSen; }

        public int getVotonulogov() { return votosnulosGov; }

        public int getVotonulopres() { return votosnulosPres; }

        public int getVotobrancoDepFed() { return votosbrancosDepFed; }

        public int getVotobrancoDepest() { return votosbrancosDepEst; }

        public int getVotobrancosen() { return votosbrancosSen; }

        public int getVotobrancosgov() { return votosbrancosGov; }

        public int getVotobrancospres() { return votosbrancosPres; }


        public void LoadCanditados() {

            lista_candidatos.Add(new Candidato("ALEXANDRE FROTA", "1234", "PSDB", @"\Imagens\DepFed1.jpg", 1)); //deputado federeal 
            lista_candidatos.Add(new Candidato("MARIA DO ROSÁRIO", "5678", "PT", @"\Imagens\DepFed2.jpg", 1)); //deputado federal 
            lista_candidatos.Add(new Candidato("CARLOS GIANNAZI", "12345", "PSOL", @"\Imagens\DepEst1.jpg", 2)); //deputado estadual
            lista_candidatos.Add(new Candidato("DR. JORGE DO CARMO", "54321", "PT", @"\Imagens\DepEst2.jpg", 2)); //deputado estadual
            lista_candidatos.Add(new Candidato("EDUARDO SUPLICY", "789", "PT", @"\Imagens\Sen1.jpg", 3)); //senador
            lista_candidatos.Add(new Candidato("JOSÉ SERRA", "456", "PSDB", @"\Imagens\Sen2.jpg", 3)); //senador
            lista_candidatos.Add(new Candidato("JOÃO DÓRIA", "45", "PSDB", @"\Imagens\Gov1.jpg", 4)); //governador
            lista_candidatos.Add(new Candidato("GUILHERME BOULOS", "50", "PSOL", @"\Imagens\Gov2.jpg", 4)); //governador
            lista_candidatos.Add(new Candidato("LULA", "13", "PT", @"\Imagens\Pres1.jpg", 5)); //presidente
            lista_candidatos.Add(new Candidato("BOLSONARO", "17", "PSL", @"\Imagens\Pres2.jpg", 5)); //presidente
        }

    }

}

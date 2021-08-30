using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caData
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data(int _dia, int _mes, int _ano)
        {
            dia = _dia;
            mes = _mes;
            ano = _ano;
            string date;
            date = String.Format("{0:00}:{1:00}:{2:0000}", dia, mes, ano);
        }

        public int Compara(Data d)
        {
            if (d.ano < ano)
            {
                return 1;
            }
            else if (d.ano > ano)
            {
                return -1;
            }
            else if (d.mes < mes)
            {
                return 1;
            }
            else if (d.mes > mes)
            {
                return -1;
            }
            else if (d.dia < dia)
            {
                return 1;
            } 
            else if(d.dia > dia)
            {
                return -1;
            }
            else { return 0;  }

        }
        public int GetDia()
        {
            return dia;
        }
        public int GetMes()
        {
            return mes;
        }
        public int GetAno()
        {
            return ano;
        }
        public string GetMesExtenso()
        {
            if(mes == 1)
            {
                return "janeiro";
            }
            else if(mes == 2)
            {
                return "fevereiro";
            }
            else if (mes == 3)
            {
                return "março";
            }
            else if (mes == 4)
            {
                return "abril";
            }
            else if (mes == 5)
            {
                return "maio";
            }
            else if (mes == 6)
            {
                return "junho";
            }
            else if (mes == 7)
            {
                return "julho";
            }
            else if (mes == 8)
            {
                return "agosto";
            }
            else if (mes == 9)
            {
                return "setembro";
            }
            else if (mes == 10)
            {
                return "outubro";
            }
            else if (mes == 11)
            {
                return "novembro";
            }
            else { return "dezembro"; }
        }

        public Boolean IsBissexto()
        {
            if((ano % 4) == 0)
            {
                return true;
            }
            else { return false; }
        }

        public Data Clone()
        {
            return new Data(dia, mes, ano);
        }
    }

}

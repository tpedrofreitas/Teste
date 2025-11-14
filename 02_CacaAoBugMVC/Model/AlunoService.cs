using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC.Model
{
     public class AlunoService
    {
        public double CalcularMedia( double n1, double n2,double n3)
        {
            //não valida entrada aqui;validações ficam no ValidacaoService/Controller
            return Math.Round( (n1+ n2+ n3) / 3.0, 2);
        }
        public string ObterSituacao(double media)
        {
            if (media >= 7.0)
                return "Aprovado";
            else if (media >= 5.0)
                return "Em Exame Final";
            else
                return "Reprovado";
        }
        public double CalcularTaxaAprovacao(int totalAlunos, int alunosAprovados)
        {
            //transforma a variavel do tipo int para double ,utilizando o CAST (Tipo)variavel
            return (alunosAprovados /(double) totalAlunos) * 100.0;
        }

    }
}

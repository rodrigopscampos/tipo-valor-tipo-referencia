using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoValorTipoReferencia
{
    public struct VPessoa
    {
        public int Idade { get; set; }

        public VPessoa(int idade)
        {
            Idade = idade;
        }
    }

    public class RPessoa
    {
        public int Idade { get; set; }

        public RPessoa(int idade)
        {
            Idade = idade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VPessoa vpessoa = new VPessoa(1);
            RPessoa rPessoa = new RPessoa(1);

            AlteraIdade(vpessoa);
            Console.WriteLine(vpessoa.Idade);

            AlteraIdadePorRef(ref vpessoa);
            Console.WriteLine(vpessoa.Idade);

            AlteraIdade(rPessoa);
            Console.WriteLine(vpessoa.Idade);

            int idade;
            Console.WriteLine(TentarExtrairIdade(rPessoa, out idade));
            Console.WriteLine(TentarExtrairIdade(null, out idade));
        }

        static void AlteraIdade(VPessoa pessoa)
        {
            pessoa.Idade = pessoa.Idade + 1;
        }

        static void AlteraIdadePorRef(ref VPessoa pessoa)
        {
            pessoa.Idade = pessoa.Idade + 1;
        }

        static void AlteraIdade(RPessoa pessoa)
        {
            pessoa.Idade = pessoa.Idade + 1;
        }

        static bool TentarExtrairIdade(
            RPessoa pessoa, 
            out int idade)
        {
            if (pessoa == null)
            {
                idade = 0;
                return false;
            }
            else
            {
                idade = pessoa.Idade;
                return true;
            }
        }
    }
}

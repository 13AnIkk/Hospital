using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Paciente : Program
    {
        public string digitado;
        public bool[] sexo = new bool[9];
        public string[] nome = new string[9];
        public int[] idade = new int[9];
        public bool[] prioridade = new bool[9];
        public string[] cpf = new string[9];
        public void paciente()
        {
            Console.WriteLine("\nO indivíduo tem prioridade?");
            digitado = Console.ReadLine();

            if (digitado == "Sim")
            {
                prioridade[0] = true;
            }
            else if (digitado == "não")
            {
                prioridade[0] = false;
            }
            Console.WriteLine("\nQual o indivíduo é do sexo Feminino ou Masculino?");
            digitado = Console.ReadLine();

            if (digitado == "Masculino")
            {
                sexo[0] = true;
            }
            else if (digitado == "Feminino")
            {
                sexo[0] = false;
            }

            Console.WriteLine("\nQual nome do indivíduo?");
            nome[0] = Console.ReadLine();

            Console.WriteLine("\nQual CPF do indivíduo?");
            cpf[0] = Console.ReadLine();

            Menu menu = new Menu();
            menu.menu();
        }

    }
    
}


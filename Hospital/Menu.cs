using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Menu : Paciente
    {
        public void menu()
        {
            Console.WriteLine("\nO que deseja fazer?\n\n1-Cadastrar paciente\n2-Listar pacientes\n3-Atenter pacientes\n4-Alterar dados de um paciente\nQ-Fechar programa\n");
            switch (Console.ReadLine())
            {
                case "1":
                    Paciente paciente = new Paciente();
                    paciente.paciente();
                    break;
                case "2":
                    
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "Q":
                    break;

            }
        }
    }
}

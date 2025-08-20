using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_de_um_jogo
{
    public class Menu
    {
        public string ExibirMenu()
        {
            string tipo = "";
            bool contador = false;
            while (contador != true)
            {
                Console.WriteLine(@"Escolha uma opção:
1 - Mago
2 - Guerreiro
3 - Monge
4 - Ninja");

                switch (Console.ReadLine())
                {
                    case "1":
                        tipo = "Mago";
                        contador = true;
                        break;

                    case "2":
                        tipo = "Guerreiro";
                        contador = true;
                        break;

                    case "3":
                        tipo = "Monge";
                        contador = true;
                        break;

                    case "4":
                        tipo = "Ninja";
                        contador = true;
                        break;

                    default:
                        Console.WriteLine("opção inválida");
                        break;
                }

            }
            return tipo;
        }
    }
}
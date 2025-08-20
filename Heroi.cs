using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_de_um_jogo
{
    public class Heroi
    {
        public Heroi(string tipo)
        {
            this.tipo = tipo;
        }

        string tipo;
        string ataque;

        public void Atacar()
        {
            switch (tipo)
            {
                case "Mago":
                    ataque = "magia";
                    break;

                case "Guerreiro":
                    ataque = "espada";
                    break;

                case "Monge":
                    ataque = "artes marciais";
                    break;

                case "Ninja":
                    ataque = "shuriken";
                    break;
            }

            Console.WriteLine($"O {tipo} atacou com {ataque}");
        }
    }
}


using System.Diagnostics;
using classes_de_um_jogo;

Menu menu = new Menu();
string tipo = menu.ExibirMenu();

Heroi heroi = new Heroi(tipo);
heroi.Atacar();


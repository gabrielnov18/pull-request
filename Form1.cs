using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpô
{
   
    public partial class Form1 : Form
    {
        enum opcoes { Pedra, Papel, Tesoura };
        enum Resultado { Jogador, CPU, Empate};       
        opcoes jogador = new opcoes();
        opcoes cpu = new opcoes();
        Random rdm = new Random();
        Resultado ganhador = new Resultado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Pedra(Object o, EventArgs e)
        {
            jogador = opcoes.Pedra;
            EscolhaJogador();
            EscolhaCPU();
            Placar();
        }
        private void Papel(Object o, EventArgs e)
        {
            jogador = opcoes.Papel;
            EscolhaJogador();
            EscolhaCPU();
            Placar();
        }
        private void Tesoura(Object o, EventArgs e)
        {
            jogador = opcoes.Tesoura;
            EscolhaJogador();
            EscolhaCPU();
            Placar();
        }
        void EscolhaJogador()
        {
            switch (jogador)
            {
                case opcoes.Pedra:
                    MinhaJogada.BackgroundImage = Image.FromFile("E:/empresa/pedra.png");
                    break;
                case opcoes.Papel:
                    MinhaJogada.BackgroundImage = Image.FromFile("E:/empresa/papel.png");
                    break;
                case opcoes.Tesoura:
                    MinhaJogada.BackgroundImage = Image.FromFile("E:/empresa/tesoura.png");
                    break;
            }
        }
        void EscolhaCPU()
        {
            int num = rdm.Next(1, 4);
            if (num == 1)
            {
                cpu = opcoes.Pedra;
                JogadaCPU.BackgroundImage = Image.FromFile("E:/empresa/pedra.png");
            }
            else if(num == 2)
            {
                cpu = opcoes.Papel;
                JogadaCPU.BackgroundImage = Image.FromFile("E:/empresa/papel.png");
            }
            else if (num == 3)
            {
                cpu = opcoes.Tesoura;
                JogadaCPU.BackgroundImage = Image.FromFile("E:/empresa/tesoura.png");
            }
            
        }

        void Placar()
        {
            switch (jogador)
            {
                case opcoes.Pedra:
                    if (cpu == opcoes.Pedra)
                    {
                        ganhador = Resultado.Empate;
                    }
                    else if (cpu == opcoes.Papel)
                    {
                        ganhador = Resultado.CPU;
                    }
                    else if (cpu == opcoes.Tesoura)
                    {
                        ganhador = Resultado.Jogador;
                    }
                    break;
                case opcoes.Papel:
                    if (cpu == opcoes.Pedra)
                    {
                        ganhador = Resultado.Jogador;
                    }
                    else if (cpu == opcoes.Papel)
                    {
                        ganhador = Resultado.Empate;
                    }
                    else if (cpu == opcoes.Tesoura)
                    {
                        ganhador = Resultado.CPU;
                    }
                    break;
                case opcoes.Tesoura:
                    if (cpu == opcoes.Pedra)
                    {
                        ganhador = Resultado.CPU;
                    }
                    else if (cpu == opcoes.Papel)
                    {
                        ganhador = Resultado.Jogador;
                    }
                    else if (cpu == opcoes.Tesoura)
                    {
                        ganhador = Resultado.Empate;
                    }
                    break;
                
                   
            }
            if (ganhador == Resultado.Jogador)
            {
                groupPlacar.BackColor = Color.Aquamarine;
                PlacarJogador.Text = (int.Parse(PlacarJogador.Text) + 1).ToString();
            }
            
            else if (ganhador == Resultado.CPU)
            {
                groupPlacar.BackColor = Color.Red;
                PlacarCPU.Text = (int.Parse(PlacarJogador.Text) + 1).ToString();
            }
            else
            {
                groupPlacar.BackColor = Color.Gray;
               
            }
        }

    }
}

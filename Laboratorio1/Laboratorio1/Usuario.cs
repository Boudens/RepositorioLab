using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1
{
    class Usuario
    {
        public string nome;
        public int idade;
        public float altura;
        public int peso;

        public Usuario(string _nome, int _idade, float _altura, int _peso)
        {
            this.nome = _nome;
            this.idade = _idade;
            this.altura = _altura;
            this.peso = _peso;
        }
    }
}

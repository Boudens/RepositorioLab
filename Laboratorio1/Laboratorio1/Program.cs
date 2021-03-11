using System;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float altura;
            int peso;
            float imc;
            float pesoIdeal;

            Console.WriteLine("Informe o nome do usuário:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a idade do usuário:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o peso do usuário:");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do usuário:");
            altura = float.Parse(Console.ReadLine());
            


            Usuario novoUsuario = new Usuario(nome, idade, altura, peso);

            imc = novoUsuario.peso / (novoUsuario.altura * novoUsuario.altura);

            if (imc >= 18.5 && imc < 24.9){
                Console.WriteLine("Parabéns "+novoUsuario.nome +" você está em seu peso normal!");
            }
            else if(imc >= 25 && imc < 29.9){
                Console.WriteLine(novoUsuario.nome + " você está acima do peso (sobrepeso).");
                pesoIdeal = 19 * (novoUsuario.altura * novoUsuario.altura);
                Console.WriteLine("A meta de peso para atingir a normalidade é de " +Math.Round(pesoIdeal,0) +" kg.");
            }
            else if (imc >= 30 && imc < 34.9)
            {
                Console.WriteLine(novoUsuario.nome + " você está classificado com Obesidade grau I.");
                pesoIdeal = 19 * (novoUsuario.altura * novoUsuario.altura);
                Console.WriteLine("A meta de peso para atingir a normalidade é de " + Math.Round(pesoIdeal, 0) + " kg.");
            }
            else if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine(novoUsuario.nome + " você está classificado com Obesidade grau II.");
                pesoIdeal = 19 * (novoUsuario.altura * novoUsuario.altura);
                Console.WriteLine("A meta de peso para atingir a normalidade é de " + Math.Round(pesoIdeal, 0) + " kg.");
            }
            else if (imc >= 40)
            {
                Console.WriteLine(novoUsuario.nome + " você está classificado com Obesidade grau III ou IV.");
                pesoIdeal = 19 * (novoUsuario.altura * novoUsuario.altura);
                Console.WriteLine("A meta de peso para atingir a normalidade é de " + Math.Round(pesoIdeal, 0) + " kg.");
            }
        }
    }
}

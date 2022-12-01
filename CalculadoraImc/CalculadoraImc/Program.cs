using System;
using System.Globalization;

namespace CalculadoraImc {
    class Program {
        static void Main(string[] args) {

            // dados usuario 
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu peso:");
            float peso = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // calculando
            float imc = (peso / (altura * altura));

            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Altura: {0} de altura", altura.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Peso: {0}", peso.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu IMC é:{0}", imc.ToString("F2", CultureInfo.InvariantCulture));

            if (imc < 16) {
                Console.WriteLine("Magreza grave !!");
            }
            else if (imc < 17) {
                Console.WriteLine("Magreza moderada");
            }
            else if (imc < 18) {
                Console.WriteLine("Magreza leve");
            }
            else if (imc < 25) {
                Console.WriteLine("Saúdavel");
            }
            else if (imc < 30) {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc < 35) {
                Console.WriteLine("Obsidade Grau I");
            }
            else if (imc < 40) {
                Console.WriteLine("Obesidade Grau II");
            }
            else {
                Console.WriteLine("Obesidade Grau III");
            }



        }
    }
}
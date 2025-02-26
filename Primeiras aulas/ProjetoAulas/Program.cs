// Console.WriteLine("Primeiro programa");

// int numero = 1;
// Console.WriteLine(numero);
// string nome = "Pedro";
// decimal valor = 200.99m;
// double valorDouble = 200.99;
// float valorFloat = 0.9f;
// var idadeNova = 34;
// char flag = 'Y';
// Console.WriteLine(flag);
// bool ativo = false;

// const string descricao = "Curso C#";
// Console.WriteLine(descricao);

using System.Collections;

var numero1 = 1;
var numero2 = 2;

// var soma = numero1 + numero2;
// Console.WriteLine(soma);

// var subtracao = numero2 - numero1;
// Console.WriteLine(subtracao);

// var multiplicacao = (numero1 * numero2) * 10;
// Console.WriteLine(multiplicacao);

// var divisao = numero2 / numero1;
// Console.WriteLine(divisao);

// bool igual = numero1 == numero2;
// Console.WriteLine(igual);

// bool maior = numero2 > numero1;
// Console.WriteLine(maior);

// bool menor = numero2 < numero1;
// Console.WriteLine(menor);

// bool menorOuIgual = numero2 <= numero1;
// Console.WriteLine(menorOuIgual);

// bool maiorOuIgual = numero2 >= numero1;
// Console.WriteLine(maiorOuIgual);

// bool diferente = numero2 != numero1;
// Console.WriteLine(diferente);

// var valido = numero2 > numero1 && 8 > 7;
// Console.WriteLine(valido);

// var valido2 = numero2 > numero1 || 6 > 7;
// Console.WriteLine(valido);

// var valido3 = !(numero2 > 10);
// Console.WriteLine(valido3);

// bool ativo = true;
// string status = !ativo ? "Cadastro Ativo" : "Cadastro inativo";
// Console.WriteLine(status);

// var nome = NomeCompleto();
// var soma = SomaValores();

// Console.WriteLine(nome);
// Console.WriteLine(soma);

// void EscreverNome()
// {
//     Console.WriteLine(nome);
//     Console.WriteLine(soma);

// }

// string NomeCompleto() 
// {
//     string primeiroNome = "Pedro";
//     string segundoNome = "Freire";

//     return primeiroNome + " " + segundoNome;
// }

// int SomaValores()
// {
//     return 8 + 2;
// }

// int SomaValores(int a, int b)
// {
//     return a + b;
// }

// var soma = SomaValores(3, 5);
// Console.WriteLine(soma);

// var nome = NomeEIdade("Rafael", 33);
// Console.WriteLine(nome);

// string NomeEIdade(string nome, int idade)
// {
//     return "Meu nome é "+ nome +" e tenho a seguinte idade: " + idade;
// }

var arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Pedro");
arrayList.Add(false);

Console.WriteLine(arrayList[1]);

arrayList.RemoveAt(1);

arrayList.Clear();

foreach(var item in arrayList)
{
    Console.WriteLine(item);
}
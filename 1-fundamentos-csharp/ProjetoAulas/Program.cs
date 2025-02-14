
// Escreve a mesangem Hello, World no console
// Console.WriteLine("Hello, World!");

//////////////////////////////////////////////
//Trabalhando com variáveis

// int idade = 43;
// Console.WriteLine(idade);

// string nome = "Jeffreys Sharp";
// Console.WriteLine(nome);

// char turma = 'A';
// Console.WriteLine(turma);

// bool ativo = true;
// Console.WriteLine(ativo);

// decimal valor = 299.99m;
// Console.WriteLine(valor);

// double valorDouble = 200.99;
// Console.WriteLine(valorDouble);

// float valorFloat = 200.99f;
// Console.WriteLine(valorFloat);

// var idadeNova = 50;
// Console.WriteLine(idadeNova);

/////////////////////////////////////////////////////
/// O QUE É UMA CONSTANTE
/// 
// const string DESCRIÇAO_CURSO = "Fundamentos do C#";
// Console.WriteLine(DESCRIÇAO_CURSO);

/////////////////////////////////////////////////////
// COMENTÁRIOS
// Escreve a mesangem Hello, World no console 
// Console.WriteLine("Hello, World!");

/* Escreve a mesangem Hello, World no console 
    Console.WriteLine("Hello, World!"); */

////////////////////////////////////////////////////
// OPERADORES DE ATRIBUIÇÃO
// Declaramos a variável idade que recebe o valor 43
//int idade = 43;
// Declaramos a variável maiorIdade como boolean 
//bool maiorIdade;
// Exibimos ambos no console, atribuindo valor ao booleano
//Console.WriteLine(idade);
//Console.WriteLine(maiorIdade = true);

////////////////////////////////////////////////////
// OPERADORES ARITIMÉTICOS

// int a = 5, b = 10, c = 15, d = 20; // declaramos quatro variáveis do tipo int
// Console.WriteLine(a + d); // operação de soma
// Console.WriteLine(c - a); // operação de subtração
// Console.WriteLine(b * c); // operação de multiplicação
// Console.WriteLine(d / b); // operação de divisão
// Console.WriteLine(c % b); // operação de módulo (resto de divisão)
 
// // ODERDEM DE OPERAÇÕES MATEMÁTICAS
// int a = 5, b = 10, c = 15, d = 20;

// Console.WriteLine(a + b * c); // A operação de multiplicação será executada primeiro
// Console.WriteLine((a + b) * c); // A operação de soma será executada primeiro porque está entre parênteses

// Operadores aritiméticos de Atribuição reduzida
// int x = 5;
// x += 5; // é a mesma coisa que x = x + 5
// Console.WriteLine("Valor do x = " + x);

// Operadores incrementais e decrementais

// Console.WriteLine("Pré-Incremento:\n");

// int x = 0;
// Console.WriteLine("x = " + x);

// Console.WriteLine("++x +20 = \n");
// Console.WriteLine(++x +20 + "\n");

// Console.WriteLine("Pós-Incremento:\n");
// x = 0;

// Console.WriteLine("\nx++ +20 = \n");
// Console.WriteLine(x++ + 20 + "\n");

// Console.WriteLine("Pré-Decremento:\n");
// x = 0;

// Console.WriteLine("x = " + x);

// Console.WriteLine("--x +20 = \n");
// Console.WriteLine(--x + 20 + "\n");

// Console.WriteLine("Pós-Decremento:\n");
// x = 0;

// Console.WriteLine("x-- +20 = \n");
// Console.WriteLine(x-- + 20 + "\n");


////////////////////////////////////////////
// OPERADORES RELACIONAIS

int a = 10, b = 25, c = 50, d = 100; // declaramos quatro variáveis de tipo int

Console.WriteLine(a == d); // Avaliamos a igualdade entre a e d
Console.WriteLine(b != c); // Avaliamos a desigualdade entre b e c
Console.WriteLine(a > b);  // Avaliamos se a é maior que b
Console.WriteLine(c < d);  // Avaliamos se c é menor que d
Console.WriteLine(c >= a); // Avaliamos se c é maior ou igual que a
Console.WriteLine(d <= b); // Avaliamos se d é menor ou igual que b
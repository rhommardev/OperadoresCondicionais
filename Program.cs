// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;

// Título: Condicionales en C#

//paso  1 declaración de variables
int quantidadeEnEstoque = 10;
int quantidadeCompra = 4;





//paso 2 bloque de codigo condicional
if (quantidadeEnEstoque >= quantidadeCompra) // si quantidade estoque es mayor o igual a quantidade compra
{
    Console.WriteLine("Venda realizada"); //impreime mensaje de venta realizada
}
else // si no se cumple la condicion
{
    Console.WriteLine("Desculpe. não temos estoque suficiente"); //imprime este mensaje
}


//ejemplo 2  
//OPERADORES LOGICOS

//OPERADOR OR 

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDosPais = false;


if (ehMaiorDeIdade || possuiAutorizacaoDosPais) // si eh maior de idade o possui autorizacion de los padres
{
    Console.WriteLine("Pode entrar na festa"); //imprime mensaje de que puede entrar a la fiesta
}

else // si no se cumple la condicion
{
    Console.WriteLine("Não pode entrar na festa"); //imprime mensaje de que no puede entrar a la fiesta
}

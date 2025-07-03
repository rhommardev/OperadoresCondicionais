// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;

// Título: Condicionales en C#
/*
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

//segundo ejemplo de condicionales
int quantidadeEmEstoque = 10; // cantidad en el inventario
int quantidadeCompra  = 4; // cantidad comprada
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;


Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"Possível venda: {possivelVenda}"); // imprime si es posible la venta    


if (possivelVenda)
{
    Console.WriteLine("Venda realizada"); //imprime mensaje de venta realizada
}
else
{
    Console.WriteLine("Desculpe. não temos estoque suficiente"); //imprime mensaje de que no hay suficiente inventario  
}
*/

//otro ejemplo de condicionales usando ELSE IF 
int quantidadeEmEstoque = 10; // cantidad en el inventario
int quantidadeCompra  = 4; // cantidad comprada
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;


Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"Possível venda: {possivelVenda}"); // imprime si es posible la venta    

if (quantidadeCompra == 0)
{ 
    Console.WriteLine("COMPRA INVALIDA"); //imprime mensaje de que el inventario esta vacio
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada"); //imprime mensaje de venta realizada
}
else
{
    Console.WriteLine("Desculpe. não temos estoque suficiente"); //imprime mensaje de que no hay suficiente inventario  
}

/*
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

//OPERADOR AND

bool possuiPresencaMinima = true;
double notaFinal = 7.5;

if (possuiPresencaMinima && notaFinal >= 6.0) // si posee presencia minima y la nota final es mayor o igual a 6
{
    Console.WriteLine("Aprovado"); //imprime mensaje de aprobado
}
else // si no se cumple la condicion
{
    Console.WriteLine("Reprovado"); //imprime mensaje de reprobado
}

//OPERADOR NOT

bool choveou = false;
bool estaTarde = false;


if (!choveou && !estaTarde) // si choveu y no esta tarde usando el simbolo ! se niega la afirmacion 
{
    Console.WriteLine("Leve um guarda-chuva"); //imprime mensaje de que lleve un paraguas
}
else // si no se cumple la condicion
{
    Console.WriteLine("Não precisa de guarda-chuva"); //imprime mensaje de que no necesita paraguas
}
//OPERADOR TERNARIO
// Declaración de variables
int idade = 17;

// Operador ternario para verificar si la persona es mayor de edad  
string resultado = (idade >= 18) ? "É maior de idade" : "É menor de idade"; // si la edad es mayor o igual a 18 imprime que es mayor de edad, si no imprime que es menor de edad
Console.WriteLine(resultado); // imprime el resultado de la verificación    
// Sí, puedes crear el archivo README.md desde VS Code:
// 1. Haz clic derecho en la carpeta del proyecto en el panel del explorador de VS Code.
// 2. Selecciona "Nuevo archivo".
// 3. Escribe "README.md" como nombre del archivo y presiona Enter.
// 4. Escribe el contenido que desees y guarda el archivo.

*/
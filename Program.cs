// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;

//SE OBSERVAN CONFLICTOS EN EL CODIGO DEBIDO A QUE SE USARON LAS MISMAS VARIABLES EN DIFERENTES EJEMPLOS. 
// QUIEN PUEDA SOLUCIONARLOS DEBE CAMBIAR LOS NOMBRES DE LAS VARIABLES PARA QUE NO HAYA CONFLICTOS.
//QUEDA A CRITERIO DEL USUARIO SI QUIERA COLABORAR EDITANDO EL CÓDIGO .



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


// ejemplo usando switch case
Console.WriteLine("Digite una vogal");
string letra = Console.ReadLine();
switch (letra) // convierte la letra a minuscula para evitar errores
{
    case "a":
        Console.WriteLine("A letra é A");
        break;
    case "e":
        Console.WriteLine("A letra é E");
        break;
    case "i":
        Console.WriteLine("A letra é I");
        break;
    case "o":
        Console.WriteLine("A letra é O");
        break;
    case "u":
        Console.WriteLine("A letra é U");
        break;
    default:
        Console.WriteLine("Não é uma vogal"); // si no es una vocal imprime este mensaje
        break;
}

//segundo ejemplo mejorando el switch case  usando if else e haciendo el codigo mas corto

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine(); 

if (
letra == "a" ||
letra == "e" ||
letra == "i" ||
letra == "o" ||
letra == "u") // si la letra es una vocal
{
    Console.WriteLine($"A letra é vogal"); // imprime la letra en mayuscula
}
else // si no es una vocal
{
    Console.WriteLine("Não é uma vogal"); // imprime mensaje de que no es una vocal
}




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


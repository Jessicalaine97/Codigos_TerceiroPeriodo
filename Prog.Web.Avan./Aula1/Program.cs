var numeros = new int[] {1, 2, 3, 4, 5};

//Func<int[], int, int[]> minhaFuncao = RetornaMaioresQue;
//terceiro int e tipo de resultado e os dois primeiros sao tipos de parametro da funcao

//var maioresQue2 = minhaFuncao(numeros, 2);

//procedimento é action e funcao é func -> passar por parametro

Func<int, bool> SelecionarPar = (int num) => {
    return num % 2 == 0;
};
//se tiver so um parametro pode deixar so (num) ao inves de (int num)
//outra escrita: Func<int, bool> SelecionarPar =  num => num % 2 == 0;

//var pares = Funcoes.Filtrar(numeros, SelecionarPar);
//var pares = numeros.Filtrar(x => x % 2 == 0); // o Filtrar apareceu por causa do this -> metodo de extensao
var pares = numeros.Filtrar(x => x % 2 ==0);

var impares = Funcoes.Filtrar(numeros, selecionarImpar);
//outra escrita: var impares = Filtrar(numeros, x => x % 2 != 0);

var maioresQue2 = Funcoes.Filtrar(numeros, x => x > 2);

Imprimir("Pares: ", pares);
Imprimir("Impares: ", impares);
Imprimir("Maiores que 2: ", maioresQue2);

static void Imprimir(string mensagem, int[] vetor)
{
    Console.Write(mensagem);

    foreach(var num in vetor)
        Console.Write($"{num} ");

    Console.WriteLine();
}

/*foreach(var num in vetor)
    Console.Write($"{num} ");

Console.WriteLine();*/

/*static bool selecionarPar(int num)
{
    return num % 2 == 0;
}*/

static bool selecionarImpar(int num)
{
    return num % 2 != 0;
}


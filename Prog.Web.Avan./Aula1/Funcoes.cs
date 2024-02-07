static class Funcoes
{
    public static int[] Filtrar(this int[] vetor, Func<int, bool> selecionar)
    {
        var resultado = new List<int>(); 

        foreach(var num in vetor)
            if(selecionar(num))
                resultado.Add(num);

        return resultado.ToArray(); //transforma os dados num vetor
    }
}
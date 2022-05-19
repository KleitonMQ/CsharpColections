using static System.Console;
using CsharpColections.helper;


static void AulaOrganizacaoComparacao()
{

    int[] lista = new int[10] { 6, 18, 100, 50, 10, 1, 95, 15, 45, 20 };
    int[] copiaLista = new int[15];
    OprecacoesArray organizar = new OprecacoesArray();

    WriteLine("Lista desorganizada");
    organizar.ImprimirArray(lista);

    WriteLine("Lista organizada.");
    //organizar.OrdenarBubleSort(ref lista);
    organizar.CopiarArray(ref lista, ref copiaLista);
    organizar.Ordenar(ref lista);
    organizar.ImprimirArray(lista);
    WriteLine("Lista Copiada antes da organização");
    organizar.ImprimirArray(copiaLista);

    bool existe = organizar.VerificarExistencia(lista, 150);

    if (existe)
    {
        WriteLine("valor procurado encontrado");
    }
    else
    {
        WriteLine("Valor procurado não encontrado.");
    }

    bool todosMaiorQue = organizar.TodosMaiorQue(lista, 0);
    WriteLine(todosMaiorQue);
}

int[] lista = new int[10] { 6, 0, 100, 18, 10, 1, 95, 15, 45, 20 };
    int[] copiaLista = new int[15];
    OprecacoesArray organizar = new OprecacoesArray();

    int valorProcurado = 20;

    int valorAchado = organizar.ObterValor(lista, valorProcurado);
    if (valorAchado > 0)
    {
        WriteLine("encontrei o valor");
    }else{
        WriteLine("NÃO encontrei o valor");
    }

    int index = organizar.ObterIndice(lista, valorProcurado);
    WriteLine(index);

    index = organizar.ObterIndice2(lista, valorProcurado);
    WriteLine(index);

WriteLine($"Capacidade atual do array {lista.Length}");
organizar.RedimensionarArray(ref lista, lista.Length*2);

WriteLine($"Capacidade após redimensionamento é {lista.Length}");

string[] arrayConvertida = organizar.ConverterArray(lista);
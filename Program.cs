using static System.Console;
using CsharpColections.helper;

int[] lista = new int[10]{6, 18, 100, 50, 10, 1, 95, 15, 45, 20};
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

if (existe){
    WriteLine("valor procurado encontrado");
}else{
    WriteLine("Valor procurado não encontrado.");
}

bool todosMaiorQue = organizar.TodosMaiorQue(lista, 0);
WriteLine(todosMaiorQue);
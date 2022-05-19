using static System.Console;
using CsharpColections.helper;

static void EstudoDeArray2()
{
    int[] lista = new int[10] { 6, 0, 100, 18, 10, 1, 95, 15, 45, 20 };
    int[] copiaLista = new int[15];
    OprecacoesArray organizar = new OprecacoesArray();

    int valorProcurado = 20;

    int valorAchado = organizar.ObterValor(lista, valorProcurado);
    if (valorAchado > 0)
    {
        WriteLine("encontrei o valor");
    }
    else
    {
        WriteLine("NÃO encontrei o valor");
    }

    int index = organizar.ObterIndice(lista, valorProcurado);
    WriteLine(index);

    index = organizar.ObterIndice2(lista, valorProcurado);
    WriteLine(index);

    WriteLine($"Capacidade atual do array {lista.Length}");
    organizar.RedimensionarArray(ref lista, lista.Length * 2);

    WriteLine($"Capacidade após redimensionamento é {lista.Length}");

    string[] arrayConvertida = organizar.ConverterArray(lista);
}
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
static void EstudoDeListas()
{
    OperacoesLista operacoesLista = new OperacoesLista();
    List<string> estados = new List<String>() { "SP", "MG", "BA" };

    string[] estadosArray = new string[] { "SC", "MT" };

    estados.Insert(0, "RJ"); //Também adiciona elemento a lista, mas permitindo escolher o indice da nova informação.

    estados.AddRange(estadosArray);
    estados.Remove("MG");

    operacoesLista.AddElemento(estados, "GO");

    operacoesLista.ImprimirLista(estados);
}
static void ConhecendoFilas()
{
    Queue<String> fila = new Queue<string>();
    fila.Enqueue("Fabricio"); //método que adiciona elemento na fila.
    fila.Enqueue("Patricio");
    fila.Enqueue("Cabeça de Bolo");

    while (fila.Count > 0)
    {
        WriteLine($"Vez de {fila.Peek()}."); //metodo .peek exibe o primeiro elemento da fila mas não remove.
        WriteLine($"{fila.Dequeue()} atendido."); //metodo.dequeue exibe o primeiro elemento da fila e remove ele.
    }

    WriteLine(fila);
}
static void ConhecendoStack()
{
    Stack<string> pilha = new Stack<string>();

    pilha.Push("Hary Pobre e a tia da merenda"); //Método push para incluir elementos a pilha.
    pilha.Push("Hary pobre e a pedra do crack");
    pilha.Push("Hary pobre e o doguinho caramelo");

    while (pilha.Count > 0) //O .count indica a quantidade de elementos na pilha.
    {
        WriteLine($"Próximo livro para leitura {pilha.Peek()}");
        WriteLine($"{pilha.Pop()} - todo lido."); //O .Pop remove o elemento do topo da pilha.
    }
}

//primeira string é uma chave, segunda string um valor para a chave.
//A chave deve ser unica, se tentar fazer duas iguais da erro na hora de compilar.
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (var item in estados)
{
    WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
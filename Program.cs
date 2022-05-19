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
static void ConhecendoDictionary()
{
    //primeira string é uma chave, segunda string um valor para a chave.
    //A chave deve ser unica, se tentar fazer duas iguais da erro na hora de compilar.
    Dictionary<string, string> estados = new Dictionary<string, string>();

    estados.Add("SP", "São Paulo");
    estados.Add("MG", "Minas Gerais");
    estados.Add("BA", "Bahia");


    string valorProcurado = "BA";
    WriteLine(estados[valorProcurado]); //Diferente das outros vetores, o dictionary faz a busca de acordo com a chave e não pelo index. 
    estados[valorProcurado] = "BA - teste de atualização"; // forma de atualizar o elemento da chave.
    WriteLine(estados[valorProcurado]);

    estados.Remove(valorProcurado); //remover um elemento pela chave.

    foreach (var item in estados)
    {
        WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
    }
    valorProcurado = "MG";
    //usando este tratamento evita erro caso a chave procurada não seja encontrada.
    //buscar de maneira direta, caso a chave não seja encontrada o programa para de rodar. 
    if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
    {
        WriteLine(estadoEncontrado);
    }
    else
    {
        WriteLine($"Chave {valorProcurado} não encontrada");
    }

}
static void EstudoLinQ()
{
    //O Language-Integrated Query (LINQ) é uma maneira de você utilizar uma sintaxe de consulta padronizada para coleções de objetos.

    int[] arrayNumeros = new int[] { 50, 1, 4, 0, 8, 100, 15, 19, 1, 0, 8, 50, 54, 60, 35 };

    var numerosParesQuery = from numeros in arrayNumeros where numeros % 2 == 0 orderby numeros select numeros;

    var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

    WriteLine("Numeros pares extraidos pelo metodo: " + string.Join(", ", numerosParesMetodo));

    WriteLine("Numeros pares extraidos pelo query: " + string.Join(", ", numerosParesQuery));

    var minimo = arrayNumeros.Min();
    var maximo = arrayNumeros.Max();
    var medio = arrayNumeros.Average();

    var soma = arrayNumeros.Sum();
    var arrayUnicos = arrayNumeros.Distinct().ToArray();  //remove valores duplicatos na array

    WriteLine($"valor mínimo {minimo}, valor maximo {maximo}, valor médio {medio}");
    WriteLine($"soma {soma}");

    WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
    WriteLine($"Array distinto: {string.Join(", ", arrayUnicos)}");
}

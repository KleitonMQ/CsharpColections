using System.Collections.Generic;
using static System.Console;
namespace CsharpColections.helper
{
    public class OperacoesLista
    {
        public void ImprimirLista(List<string> lista)
        {
            foreach (var item in lista)
            {
                Write($"{item} ");
            }
        }
        public void AddElemento(List<string> lista, string info)
        {
            lista.Add(info);
        }

        public void RemoverElemento(List<string> lista, string info)
        {
            lista.Remove(info);
        }
    }
}
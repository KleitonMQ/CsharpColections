using static System.Console;

namespace CsharpColections.helper
{
    public class OprecacoesArray
    {
        public void OrdenarBubleSort(ref int[] array)
        {
            int temp = 0;
            foreach (var item in array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            foreach (var item in array)
            {
                Write($"{item} ");
            }
            WriteLine();
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }
        public void CopiarArray(ref int[] arrayOriginal, ref int[] arrayCopia)
        {
            Array.Copy(arrayOriginal, arrayCopia, arrayOriginal.Length);
        }

        public bool VerificarExistencia(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.FindIndex(array, elemento => elemento == valor);
        }
        public int ObterIndice2(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }
        public void RedimensionarArray(ref int[] array, int novoTamanho){
          Array.Resize(ref array, novoTamanho);   
        }

        public string[] ConverterArray(int[] array){
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}


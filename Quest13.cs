using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lista
{
	internal static class Quest13
  {
    private static void Main(string[] args)
    {
      Console.Write("Quantos nomes você deseja inserir? ");
      int n = int.Parse(Console.ReadLine());
      
      // adicionando o número que o usuário digitou
      string[] nomes = new string[n];
      
      // Lê os nomes do usuário
      for (int i = 0; i < n; i++){
        Console.Write("Digite o nome #{0}: ", i + 1);
        nomes[i] = Console.ReadLine(); 
      } 
      
      // Ordena o array de nomes usando o Bubble Sort 
      BubbleSort(nomes); 
      
      // Exibe a lista de nomes ordenada 
      Console.WriteLine("\nNomes em ordem alfabética:"); 
      foreach (string nome in nomes) { Console.WriteLine(nome); } 
    } 
    
    // Função para ordenar o vetor de strings usando Bubble Sort
    static void BubbleSort(string[] arr) {
      int n = arr.Length;
      bool trocou; 

      for (int i = 0; i < n - 1; i++) {
        trocou = false; 
        for (int j = 0; j < n - i - 1; j++) {
          if (string.Compare(arr[j], arr[j + 1]) > 0) {
            // Troca os elementos string 
            string temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
            trocou = true;
          }
        } 
        // Se não houve troca, a lista está ordenada 
        if (!trocou) 
          break;
      } 
    }
  }
}
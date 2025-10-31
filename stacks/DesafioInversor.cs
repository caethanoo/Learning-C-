using System.Collections.Generic;
using System;


public class DesafioInversor
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra para inverter:");
        string palavra = Console.ReadLine(); // Ex: "Gemini"
        string palavraInvertida = "";

        // 1. Crie sua Stack de caracteres
        Stack<char> pilhaDeLetras = new Stack<char>();

        // 2. Empilhe cada letra da 'palavra' na pilha
        // (Você pode usar um loop 'foreach' aqui)
        // foreach (char letra in palavra) { ... }

        foreach (char letra in pilhaDeLetras)
        {
            pilhaDeLetras.Push(letra);
        }

        foreach (char letra in pilhaDeLetras)
        {
            Console.WriteLine("{letra}");
        }


        // 3. Desempilhe letra por letra e junte na 'palavraInvertida'
        // (Você pode usar um loop 'while' aqui. Dica: continue enquanto a pilha não estiver vazia)
        // (Dica 2: para checar se a pilha está vazia, use pilhaDeLetras.Count > 0)
        
        while (pilhaDeLetras.Count < 0)
        {
            char LetraDoTopo = pilhaDeLetras.Pop();
            palavraInvertida = palavraInvertida + LetraDoTopo;
        }
        
    

        Console.WriteLine($"Palavra invertida: {palavraInvertida}");
    }
}
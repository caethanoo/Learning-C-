using System.Collections.Generic;
using System;

public class DesafioBalanceamento
{
    public static void Main(string[] args)
    {
        // Teste alguns casos
        string teste1 = "()[]{}";
        string teste2 = "([{}])";
        string teste3 = "([)]";
        string teste4 = "{[]";

        Console.WriteLine($"'{teste1}' é válido? {EstaBalanceado(teste1)}"); // Esperado: True
        Console.WriteLine($"'{teste2}' é válido? {EstaBalanceado(teste2)}"); // Esperado: True
        Console.WriteLine($"'{teste3}' é válido? {EstaBalanceado(teste3)}"); // Esperado: False
        Console.WriteLine($"'{teste4}' é válido? {EstaBalanceado(teste4)}"); // Esperado: False
    }

    public static bool EstaBalanceado(string s)
    {
        Stack<char> pilhaDeAbertura = new Stack<char>();

        // 1. Varra cada caractere na string 's'
        foreach (char c in s)
        {
            // 2. Se for um caractere de ABERTURA...
            if (c == '(' || c == '[' || c == '{')
            {
                // ... O que você faz com ele? ...
                // SEU CÓDIGO AQUI
            }
            // 3. Se for um caractere de FECHAMENTO...
            else if (c == ')' || c == ']' || c == '}')
            {
                // 3a. O que acontece se a pilha estiver vazia aqui?
                // (Dica: if (pilhaDeAbertura.Count == 0) ...)
                // Se estiver vazia, é inválido. Retorne 'false' imediatamente.
                
                // ... SEU CÓDIGO AQUI ...


                // 3b. Se não estiver vazia, pegue o topo (Pop) e compare.
                char ultimoAberto = ' '; // ... Use o Pop() aqui ...
                
                // Verifique se o 'c' (fechamento) combina com o 'ultimoAberto'
                // Dica:
                // if (c == ')' && ultimoAberto != '(') { return false; }
                // if (c == ']' && ultimoAberto != '[') { ... }
                // if (c == '}' && ultimoAberto != '{') { ... }

                // ... SEU CÓDIGO AQUI ...
            }
        }

        // 4. Depois que o loop acabar, como sabemos se é válido?
        // (Lembre-se: a pilha deve estar vazia)
        // (Dica: você pode retornar uma verificação booleana)
        // return ... ? ...;
        
        // ... SEU CÓDIGO AQUI ...
        return false; // Apague este 'return false' e coloque sua lógica final
    }
}
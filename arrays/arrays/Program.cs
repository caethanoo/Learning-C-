// Você tem um diário de temperaturas da semana, guardado em um array. 
//Você precisa descobrir qual foi a temperatura mais alta registrada.


using System;

int[] temperaturas = { 22, 25, 19, 30, 28, 31, 27 };

int MaiorAteAgora = temperaturas[0];

for (int i = 1; i < temperaturas.Length; i++)
{
    if (temperaturas[i] > MaiorAteAgora)
    {
        MaiorAteAgora = temperaturas[i];
    }
}

Console.WriteLine("A temperatura mais alta registrada na semana foi: " + MaiorAteAgora + "°C");

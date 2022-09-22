using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class BJ1620
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> pokemonList = new Dictionary<string, int>();
        Dictionary<int, string> indexList = new Dictionary<int, string>();

        var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int N = inputs[0];
        int M = inputs[1];

        for (int i = 0; i < N; i++)
        {
            string pokemon = Console.ReadLine();
            pokemonList.Add(pokemon, i + 1);
            indexList.Add(i + 1, pokemon);
        }

        StringBuilder stb = new StringBuilder();
        for (int j = 0; j < M; j++)
        {
            string test = Console.ReadLine();

            if (pokemonList.Keys.Contains(test))
            {
                stb.Append(pokemonList[test] + "\n");
            }
            else
            {
                stb.Append(indexList[int.Parse(test)] + "\n");
            }
        }

        Console.WriteLine(stb);
    }

}
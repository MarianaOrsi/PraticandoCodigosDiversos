﻿using System;



namespace Crescente {
    class Program {
        static void Main(string[] args) {

            int x, y;

            Console.WriteLine("Digite dois numeros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) {
                if (x < y) {
                    Console.WriteLine("CRESCENTE");

                }
                else {
                       Console.WriteLine("DECRESCENTE");
                }
                Console.WriteLine("Digite outros dois numeros:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }

        }
    }
}

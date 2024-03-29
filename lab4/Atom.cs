﻿using System;
using System.Collections.Generic;

namespace lab3.ex1
{
    public class Atom
    {
        public int number { get; set; }
        public string symbol { get; set; }
        public string fullName { get; set; }
        public double weight { get; set; }

        public List<Atom> _listAtom = new List<Atom>();

        public bool Accept()
        {
            Console.WriteLine("Enter atomic number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter symbol : ");
            var symbol = Console.ReadLine();
            Console.WriteLine("Enter full name : ");
            var fullName = Console.ReadLine();
            Console.WriteLine("Enter atomic weight : ");
            var weight = Convert.ToDouble(Console.ReadLine());
            _listAtom.Add(new Atom()
            {
                number = number,
                symbol = symbol,
                fullName = fullName,
                weight = weight
            });
            return true;
        }

        public void Distplay()
        {
            for (int i = 0; i < _listAtom.Count; i++)
            {
                Atom atom = _listAtom[i];
                // Console.WriteLine($"Number: {atom.number},Symbol: {atom.symbol},Full Name: {atom.fullName}, Weight: {atom.weight}");
                if (_listAtom.Count > 10)
                {
                    Console.WriteLine("chi nhan toi da 10 phan tu: ");
                }
                else
                {
                    Console.WriteLine(
                        $"Number: {atom.number},Symbol: {atom.symbol},Full Name: {atom.fullName}, Weight: {atom.weight}");
                }
            }
        }
    }
}
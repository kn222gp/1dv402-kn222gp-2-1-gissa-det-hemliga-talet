﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    // Making class "SecretNumber" public so that all other classes can reach the code.
    public class SecretNumber
    {

        // 1. Create variables.
        private int _number;
        private int _count;
        public const int MaxNumberOfGuesses = 7;
        Random rnd = new Random(); // Creates a new Random, called rnd.

        // Constructor that runs the method, Initialize().
        public SecretNumber() 
        {
            Initialize();
        }

        // 2. Public method that runs from Program.cs
        public void Initialize()
        {
           _count = 0;
           _number = rnd.Next(1, 101); // Gives _number a random integer between 1 and 100.
        }

        // 3. This is where the guessing happens.
        public bool MakeGuess(int number)
        {

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_count < MaxNumberOfGuesses)
            {
                _count++;

                if (number == _number)
                {
                    Console.WriteLine("Grattis! Du gissade rätt på {0} försök.", _count);
                    return true;
                }

                if (number < _number)
                {
                    Console.WriteLine("{0} är för lågt! Gissa på något högre.\nDu har {1} gissningar kvar.\n", number, MaxNumberOfGuesses - _count);
                }

                if (number > _number)
                {
                    Console.WriteLine("{0} är för högt! Gissa på något lägre.\nDu har {1} gissningar kvar.\n", number, MaxNumberOfGuesses - _count);
                }
                if (_count == MaxNumberOfGuesses)
                {
                    Console.WriteLine("Tyvärr, du har gissat för många gånger! Det hemliga talet var: {0}\n", _number);
                }
                return false;
            }

            else
            {
                throw new ApplicationException();
            }
        }

    }

}

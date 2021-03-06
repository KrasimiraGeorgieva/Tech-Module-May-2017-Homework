﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main()
        {
            var namesEmails = new Dictionary<string, string>();

            var line = Console.ReadLine();
            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                namesEmails[name] = email;

                line = Console.ReadLine();
            }

            var fixedEmail = namesEmails
                .Where(kvp =>
                !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk"))).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach(var nameEmail in fixedEmail)
            {
                var name = nameEmail.Key;
                var email = nameEmail.Value;

                Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}

using System.Text.RegularExpressions;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("----- Hash 'N Salt -----");

while (true) {
    Console.Write("Provide a password to hash: ");
    byte[] hash = CryptographyManager.GetHash(Console.ReadLine(), out byte[] salt);

    Console.WriteLine($"""

        Hash: {Convert.ToHexString(hash)}

        Salt: {Convert.ToHexString(salt)}

        """);


}


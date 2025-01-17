using System.Security.Cryptography;
using System.Text;

namespace AS_Coursework.Model.Security;

// A static helper class to deal with hashing and salting of a password
internal static class CryptographyManager {

    // Use the SHA512 algorithm
    private static readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA512;

    // The number of iterations of the hash algorithm. This is a large number to slow down brute force attacks
    private const int ITERATIONS = 100000;

    // The length of the salt
    private const int SIZE = 64;

    public static byte[] GetHash(string text, out byte[] salt) {
        // Generate a cryptographically secure salt
        salt = RandomNumberGenerator.GetBytes(SIZE);

        // Convert the text to an array of bytes
        byte[] textBytes = Encoding.UTF8.GetBytes(text);

        // Use the hash algorithm to get the bytes of the hash
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(textBytes, salt, ITERATIONS, _hashAlgorithm, SIZE);

        return hash;
    }

    public static bool VerifyHashEquality(string text, byte[] hash, byte[] salt) {
        // Convert the text to an array of bytes
        byte[] textBytes = Encoding.UTF8.GetBytes(text);

        // Use the hash algorithm to get the bytes of the hash
        byte[] hashedText = Rfc2898DeriveBytes.Pbkdf2(textBytes, salt, ITERATIONS, _hashAlgorithm, SIZE);

        // Use a fixed time equals to prevent time based attacks
        return CryptographicOperations.FixedTimeEquals(hash, hashedText);
    }
}

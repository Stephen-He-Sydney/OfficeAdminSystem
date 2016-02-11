using System;
using System.Security.Cryptography;

namespace OfficeAdmin.Service.Helpers
{
    public static class CryptoRandomGenerator
    {
        public static int GenerateRandomNumber()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Buffer storage.
            byte[] data = new byte[4];


            // Fill buffer.
            rng.GetBytes(data);

            // Convert to int 32.
            int value = BitConverter.ToInt32(data, 0);
            rng.Dispose();

            return value;
        }
    }
}
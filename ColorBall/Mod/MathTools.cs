using System;
using System.Security.Cryptography;

namespace ColorBall.Mod
{
    public class MathTools
    {
        public static int Random(int starNum, int endNum)
        {
            byte [] randomBytes = new byte[4];
            RNGCryptoServiceProvider rngProvider = new RNGCryptoServiceProvider();
            rngProvider.GetBytes(randomBytes);
            Int32 iSeed = BitConverter.ToInt32(randomBytes, 0);
            Random random = new Random(iSeed);
            return random.Next(starNum, endNum + 1);
        }

    }
}

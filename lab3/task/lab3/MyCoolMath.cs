using System.Numerics;

namespace lab3
{
    public static class MyCoolMath
    {
        public static BigInteger ModPow(BigInteger number, BigInteger power, BigInteger modulus)
        {
            BigInteger result = 1;

            while (power > 0)
            {
                if (power % 2 == 1)
                {
                    result = result * number % modulus;
                }
                number = number * number % modulus;
                power /= 2;
            }

            return result;
        }

        public static List<BigInteger> Primitives(BigInteger p)
        {
            var result = new List<BigInteger>();

            if (p == 2)
            {
                result.Add(BigInteger.One);
            }

            var phi = p - 1;

            var primeFactors = PrimeFactors(phi);
            if (p.CompareTo(UInt16.MaxValue) > 0)
            {
                for (BigInteger g = 2; result.Count < 1000; g++)
                {
                    bool isPrimitiveRoot = true;

                    foreach (var factor in primeFactors)
                    {
                        if (MyCoolMath.ModPow(g, phi / factor, p) == 1)
                        {
                            isPrimitiveRoot = false;
                            break;
                        }
                    }

                    if (isPrimitiveRoot)
                    {
                        result.Add(g);
                    }
                }
            }
            else
            {
                for (BigInteger g = 2; g < p; g++)
                {
                    bool isPrimitiveRoot = true;

                    foreach (var factor in primeFactors)
                    {
                        if (MyCoolMath.ModPow(g, phi / factor, p) == 1)
                        {
                            isPrimitiveRoot = false;
                            break;
                        }
                    }

                    if (isPrimitiveRoot)
                    {
                        result.Add(g);
                    }
                }
            }


            return result;
        }

        private static List<BigInteger> PrimeFactors(BigInteger n)
        {
            var factors = new List<BigInteger>();

            while (n % 2 == 0)
            {
                factors.Add(2);
                n /= 2;
            }

            for (BigInteger i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }

            if (n > 2) factors.Add(n);

            return factors;
        }


        public static BigInteger[] EuclideanExt(BigInteger a, BigInteger b)
        {
            if (b == BigInteger.Zero)
            {
                return new BigInteger[] { a, BigInteger.One, BigInteger.Zero };
            }

            BigInteger[] vals = EuclideanExt(b, a % b);
            BigInteger d = vals[0];
            BigInteger x = vals[2];
            BigInteger y = vals[1] - (a / b) * vals[2];
            return new BigInteger[] { d, x, y };
        }

        public static bool IsPrime(BigInteger n, int witnessCount = 10)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            BigInteger d = n - 1;
            int r = 0;
            while ((d & 1) == 0)
            {
                r++;
                d >>= 1;
            }

            for (int i = 0; i < witnessCount; i++)
            {
                BigInteger a = GenerateRandomBase(n);

                BigInteger x = BigInteger.ModPow(a, d, n);

                if (x == 1 || x == n - 1) continue;

                bool isWitness = false;
                for (int j = 0; j < r - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, n);

                    if (x == n - 1)
                    {
                        isWitness = true;
                        break;
                    }
                }

                if (!isWitness) return false;
            }

            return true;
        }

        private static BigInteger GenerateRandomBase(BigInteger n)
        {
            var random = new Random();
            BigInteger a;
            do
            {
                byte[] bytes = new byte[n.ToByteArray().Length];
                random.NextBytes(bytes);
                a = new BigInteger(bytes);
                a = BigInteger.Abs(a);
            } while (a <= 1 || a >= n - 1);

            return a;
        }
    }
}

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Digests;

namespace eazy_HASH
{
    internal class EazyHasher
    {
        private string inputPath;
        private string outputPath;
        private string hashName;

        public EazyHasher(string inputPath, string outputPath, string hashName)
        {
            this.inputPath = inputPath;
            this.outputPath = outputPath;
            this.hashName = hashName.ToUpper().Trim();
        }

        public void SetInputPath(string inputPath)
        {
            this.inputPath = inputPath;
        }

        public void SetOutputPath(string outputPath)
        {
            this.outputPath = outputPath;
        }

        public void SetHashName(string hashName)
        {
            this.hashName = hashName.ToUpper().Trim();
        }

        public async Task HashFileAsync()
        {
            string output = await Task.Run(() =>
            {
                string input = File.ReadAllText(inputPath).Trim();
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                string result = "";

                switch (hashName)
                {
                    case "MD5":
                        result = ComputeMD5(inputBytes);
                        break;
                    case "RIPEMD160":
                        result = ComputeRIPEMD160(inputBytes);
                        break;
                    case "SHA1":
                        result = ComputeSHA1(inputBytes);
                        break;
                    case "SHA256":
                        result = ComputeSHA256(inputBytes);
                        break;
                    case "SHA3_256":
                        result = ComputeSHA3_256(inputBytes);
                        break;
                    case "SHA3_384":
                        result = ComputeSHA3_384(inputBytes);
                        break;
                    case "SHA3_512":
                        result = ComputeSHA3_512(inputBytes);
                        break;
                    case "SHA384":
                        result = ComputeSHA384(inputBytes);
                        break;
                    case "SHA512":
                        result = ComputeSHA512(inputBytes);
                        break;
                    default:
                        Console.WriteLine("Unsupported hash algorithm.");
                        return "";
                }

                return result;
            });

            await File.WriteAllTextAsync(outputPath, output);
        }

        private string ComputeMD5(byte[] inputBytes)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }

        private string ComputeRIPEMD160(byte[] inputBytes)
        {
            RipeMD160Digest ripemd160 = new RipeMD160Digest();
            ripemd160.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] hashBytes = new byte[ripemd160.GetDigestSize()];
            ripemd160.DoFinal(hashBytes, 0);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }

        private string ComputeSHA1(byte[] inputBytes)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }

        private string ComputeSHA256(byte[] inputBytes)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }

        private string ComputeSHA3_256(byte[] inputBytes)
        {
            var sha3 = new Sha3Digest(256); // Correct the class name to 'Sha3Digest' and specify the bit length
            sha3.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] hashBytes = new byte[sha3.GetDigestSize()];
            sha3.DoFinal(hashBytes, 0);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }

        private string ComputeSHA3_384(byte[] inputBytes)
        {
            var sha3 = new Sha3Digest(384); // Correct the class name to 'Sha3Digest' and specify the bit length
            sha3.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] hashBytes = new byte[sha3.GetDigestSize()];
            sha3.DoFinal(hashBytes, 0);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }

        private string ComputeSHA3_512(byte[] inputBytes)
        {
            var sha3 = new Sha3Digest(512); // Correct the class name to 'Sha3Digest' and specify the bit length
            sha3.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] hashBytes = new byte[sha3.GetDigestSize()];
            sha3.DoFinal(hashBytes, 0);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }

        private string ComputeSHA384(byte[] inputBytes)
        {
            using (SHA384 sha384 = SHA384.Create())
            {
                byte[] hashBytes = sha384.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }

        private string ComputeSHA512(byte[] inputBytes)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] hashBytes = sha512.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }
    }
}

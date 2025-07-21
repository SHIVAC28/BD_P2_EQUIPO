using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Ventas_SHIVAC
{
   

    public static class CifradorAES
    {
        public static byte[] Cifrar(string texto, string clave)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(clave.PadRight(32).Substring(0, 32)); // AES256 requiere 32 bytes
                aes.IV = new byte[16]; // Vector de inicialización (puede ser fijo o aleatorio)

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(texto);
                    }

                    return ms.ToArray(); // ✅ Correcto: dentro del bloque de ms
                }
            }
        }

        public static string Descifrar(byte[] datos, string clave)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(clave.PadRight(32).Substring(0, 32));
                aes.IV = new byte[16];

                using (MemoryStream ms = new MemoryStream(datos))
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}

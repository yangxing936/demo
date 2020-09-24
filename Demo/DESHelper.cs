// Decompiled with JetBrains decompiler
// Type: NET_IntcptPrt.DESHelper
// Assembly: NET_IntcptPrt, Version=1.0.6264.29796, Culture=neutral, PublicKeyToken=null
// MVID: 3AA4CB5C-3958-4928-9165-51526F7C0F15
// Assembly location: C:\Users\周瑜\Documents\WeChat Files\hai_bo1015\Files\二维码部署\覆盖BIN\NET_IntcptPrt.dll

using System;
using System.Security.Cryptography;
using System.Text;

namespace Demo
{
    public class DESHelper
    {
        public static string Encrypt3Des(
          string aStrString,
          string aStrKey,
          CipherMode mode = CipherMode.ECB,
          string iv = "12345678")
        {
            try
            {
                TripleDESCryptoServiceProvider cryptoServiceProvider1 = new TripleDESCryptoServiceProvider();
                cryptoServiceProvider1.Key = Encoding.UTF8.GetBytes(aStrKey);
                cryptoServiceProvider1.Mode = mode;
                TripleDESCryptoServiceProvider cryptoServiceProvider2 = cryptoServiceProvider1;
                if (mode == CipherMode.CBC)
                    cryptoServiceProvider2.IV = Encoding.UTF8.GetBytes(iv);
                ICryptoTransform encryptor = cryptoServiceProvider2.CreateEncryptor();
                byte[] bytes = Encoding.UTF8.GetBytes(aStrString);
                return Convert.ToBase64String(encryptor.TransformFinalBlock(bytes, 0, bytes.Length));
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public static string Decrypt3Des(
          string aStrString,
          string aStrKey,
          CipherMode mode = CipherMode.ECB,
          string iv = "12345678")
        {
            try
            {
                TripleDESCryptoServiceProvider cryptoServiceProvider1 = new TripleDESCryptoServiceProvider();
                cryptoServiceProvider1.Key = Encoding.UTF8.GetBytes(aStrKey);
                cryptoServiceProvider1.Mode = mode;
                cryptoServiceProvider1.Padding = PaddingMode.PKCS7;
                TripleDESCryptoServiceProvider cryptoServiceProvider2 = cryptoServiceProvider1;
                if (mode == CipherMode.CBC)
                    cryptoServiceProvider2.IV = Encoding.UTF8.GetBytes(iv);
                ICryptoTransform decryptor = cryptoServiceProvider2.CreateDecryptor();
                byte[] inputBuffer = Convert.FromBase64String(aStrString);
                return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}

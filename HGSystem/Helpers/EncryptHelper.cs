using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace HGSystem.Helpers
{
    public class EncryptHelper
    {
        public static string CreateMD5Hash(string input)
        {
            // Use input string to calculate MD5 hash
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
                // To force the hex string to lower-case letters instead of
                // upper-case, use he following line instead:
                // sb.Append(hashBytes[i].ToString("x2")); 
            }
            return sb.ToString();
        }

        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string MD5Encrypt32(string password)
        {
            string cl = password;
            string pwd = "";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create(); //实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("x");
            }
            return pwd;
        }

        public static string SHA256(String file, bool is_file)
        {
            if (is_file)
            {
                if (file == null || !File.Exists(file))
                    return null;
                try
                {
                    FileStream stream = new FileStream(file, FileMode.Open);

                    SHA256Managed Sha256 = new SHA256Managed();
                    byte[] by = Sha256.ComputeHash(stream);
                    stream.Close();

                    return BitConverter.ToString(by).Replace("-", "").ToLower(); //64
                    //return Convert.ToBase64String(by);                         //44
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception " + e.Message);
                    return null;
                }
            }
            else
            {
                //如果str有中文，不同Encoding的sha是不同的！！
                byte[] SHA256Data = Encoding.UTF8.GetBytes(file);

                SHA256Managed Sha256 = new SHA256Managed();
                byte[] by = Sha256.ComputeHash(SHA256Data);

                return BitConverter.ToString(by).Replace("-", "").ToLower(); //64
            }
        }
    }
}

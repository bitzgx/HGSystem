using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ourtm.Common.Files
{
    /// <summary>
    /// 读取文件内容
    /// </summary>
    public class ReadFile
    {
        public static ReadFile Current = new ReadFile();
        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="path">路径和名字 a\\b.txt 以更目录开头</param>
        /// <returns></returns>
        public string Read(string path)
        {
            string result = string.Empty;
            string PathFile = $"{System.AppDomain.CurrentDomain.BaseDirectory}{path}";
            if (System.IO.File.Exists(PathFile))
            {
                using (var fs = new FileStream(PathFile, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (var rs = new StreamReader(fs))
                    {
                        result = rs.ReadToEnd();
                    }
                }
            }
            return result;
        }
    }
}

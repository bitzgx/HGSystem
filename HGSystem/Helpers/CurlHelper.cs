using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace HGSystem.Helpers
{
    public class CurlHelper
    {
        //private string getCommand()
        //{
        //    return string.Format(" -F media=@\"{0}\" \"https://api.weixin.qq.com/cgi-bin/media/upload?access_token={1}&type=images\""
        //        , this.FileName
        //        , this.config.Access_Token
        //        );
        //  }
                /// <summary>
        /// 运行cmd命令
        /// 不显示命令窗口
        /// </summary>
        /// <param name="cmdExe">指定应用程序的完整路径</param>
        /// <param name="cmdStr">执行命令行参数</param>
        public static string RunCmd2(string cmdStr)
        {
            try
            {
                using (Process myPro = new Process())
                {
                    //指定绝对路径
                    // myPro.StartInfo.FileName = @"I:\AppSolution\curl_pkg\curl-7.57.0-win64-mingw\bin\curl.exe";
                    //使用环境变量路径
                    // string enPath = Environment.GetEnvironmentVariable("CURL_HOME");
                    String enPath = @"D:\zhangguixin\myapps\HGSystem\HGSystem";
                    // LogOperate.Write("当前命令的环境变量：" + enPath);
                    myPro.StartInfo.FileName = enPath + @"\curl.exe";
                    myPro.StartInfo.UseShellExecute = false;
                    myPro.StartInfo.RedirectStandardInput = true;
                    myPro.StartInfo.RedirectStandardOutput = true;
                    myPro.StartInfo.RedirectStandardError = true;
                    myPro.StartInfo.CreateNoWindow = true;
                    myPro.StartInfo.Arguments = cmdStr; //指定参数
                    myPro.Start();
                    myPro.StandardInput.AutoFlush = true;

                    //获取cmd窗口的输出信息
                    string output = myPro.StandardOutput.ReadToEnd();

                    myPro.WaitForExit();
                    myPro.Close();

                    return output;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

              #region 远程调用
        /// <summary>
        /// 上传图片返回图片id
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string PostFile(string url, string filename)
        {
            try
            {
                //this.FileName = AppDomain.CurrentDomain.BaseDirectory + "data/" + filename;
                //string command = getCommand();

                string command = "curl -XPOST " + url + "-F\"filename=" + filename + "\"";
 
                //执行命令获取mediaid
                string backdata = RunCmd2(command);
                // LogOperate.Write("backdata:" + backdata);
                return backdata;
 
                //JObject obj = JObject.FromObject(backdata);
                //JToken media_id = obj.SelectToken("media_id");
                //if (media_id == null)
                //    throw new Exception($"获取media_id失败，" + backdata);
                //return media_id.ToString();
            }
            catch (Exception ex)
            {
                // LogOperate.Write("上传素材出错：" + ex.Message + "|" + ex.StackTrace);
            }
            return string.Empty;
        }
        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace HGSystem
{
    public partial class MainForm : Form
    {
        ContentPublish m_ctl_contentpublish;
        HGPlan m_ctl_hgplan;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (m_ctl_contentpublish == null) {
                m_ctl_contentpublish = new ContentPublish();
                m_ctl_contentpublish.Location = new Point(0, 150);
                this.Controls.Add(m_ctl_contentpublish);
            }
            if (m_ctl_contentpublish != null) m_ctl_contentpublish.BringToFront();            
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PointF p1 = new PointF(10, 75);
            PointF p2 = new PointF(this.Width - 10, 75);            
            g.DrawLine(new Pen(Color.Gray, 2), p1, p2);
        }

        private void m_btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btn_hgplan_Click(object sender, EventArgs e)
        {
            if (m_ctl_hgplan == null) {
                m_ctl_hgplan = new HGPlan();
                m_ctl_hgplan.Location = new Point(0, 150);
                this.Controls.Add(m_ctl_hgplan);
            }
            if (m_ctl_hgplan != null) m_ctl_hgplan.BringToFront();
        }

        private void m_btn_material_Click(object sender, EventArgs e)
        {
            /*
            string url="Http://www.baidu.com";
            string res = HTTPClientHelper.GetHttpResponse(url, 6000);
            if (res != null)
            {
                Console.WriteLine(res);
                // T mes = JsonHelper.DeserializeJsonToObject<T>(res)
            }
            */
            //参数p
            /*
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            // parameters.Add("p", HttpUtility.UrlEncode(p));
            string url = "https://edutest.hongkazhijia.com/platform/login/getImage";
            //http请求
            System.Net.HttpWebResponse res = HTTPClientHelper.CreatePostHttpResponse(url, parameters, 3000, null, null);
            if (res == null)
            {
                // Response.Redirect("RequestFailed.aspx?result=出错了,可能是由于您的网络环境差、不稳定或安全软件禁止访问网络，您可在网络好时或关闭安全软件在重新访问网络。");
                Console.WriteLine("RequestFailed.aspx?result=出错了,可能是由于您的网络环境差、不稳定或安全软件禁止访问网络，您可在网络好时或关闭安全软件在重新访问网络。");
            }
            else
            {
                //获取返回数据转为字符串
                string mes = HTTPClientHelper.GetResponseString(res);
                Console.WriteLine(res);
                // T model = JsonHelper.DeserializeJsonToObject<T>(mes);
            }
            */
            
            string strURL = "https://edutest.hongkazhijia.com/platform/login/getImage";
            /*
            System.Net.HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            //Post请求方式
            request.Method = "POST";
            // 内容类型
            request.ContentType = "application/x-www-form-urlencoded";
            // 参数经过URL编码
            // string paraUrlCoded = System.Web.HttpUtility.UrlEncode("keyword");
            // paraUrlCoded += "=" + System.Web.HttpUtility.UrlEncode("多月");
            // byte[] payload;
            //将URL编码后的字符串转化为字节
            // payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            //设置请求的 ContentLength 
            // request.ContentLength = payload.Length;
            //获得请 求流
            // System.IO.Stream writer = request.GetRequestStream();
            //将请求参数写入流
            // writer.Write(payload, 0, payload.Length);
            // 关闭请求流
            // writer.Close();
            System.Net.HttpWebResponse response;
            // 获得响应流
            response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();
            myreader.Close();
            Console.WriteLine(responseText);
            */

            // String res = HttpHelper.HttpPostData(strURL, null);
            // Console.WriteLine(res);

            HGRestfulAPI.getInstance().getHGComCategory();
        }
    }
}
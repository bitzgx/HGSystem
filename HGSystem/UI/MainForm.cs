using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HGSystem.UserControls;
using HGSystem.Model;

namespace HGSystem
{
    public partial class MainForm : Form
    {
        private ContentPublish m_ctl_contentpublish;
        private HGPlan m_ctl_hgplan;
        private Material m_ctl_material;

        private int m_uc_offset;
        private ButtonEx m_buttonex_checked;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_uc_offset = 110;

            InitNavigators();

            ButtonExChecked(m_btn_content);

            m_btn_content_Click(this, null);

            HGData.getInstance().ComCategory = HGRestfulAPI.getInstance().getHGComCategory();
        }

        private void InitNavigators()
        {
            SetButtonExDefault(m_btn_content);
            SetButtonExDefault(m_btn_hgplan);
            SetButtonExDefault(m_btn_material);
        }

        private void ButtonExChecked(ButtonEx be)
        {
            if (m_buttonex_checked != null) SetButtonExDefault(m_buttonex_checked);
            if (be == null) return;
            m_buttonex_checked = be;
            SetButtonExChecked(m_buttonex_checked);
        }
        private void SetButtonExDefault(ButtonEx be)
        {
            be.Radius = 40;
            be.Size = new Size(116, 36);
            be.ForeColor = Color.Black;
            be.BaseColor = Color.White;
            be.Font = new Font("宋体", 10f, FontStyle.Bold);
        }

        private void SetButtonExChecked(ButtonEx be)
        {
            be.ForeColor = Color.White;
            be.BaseColor = Color.FromArgb(255, 100, 92);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            /*
            Graphics g = e.Graphics;
            PointF p1 = new PointF(10, 75);
            PointF p2 = new PointF(this.Width - 10, 75);            
            g.DrawLine(new Pen(Color.Gray, 2), p1, p2);
             */
        }

        private void m_btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BringToFrontUserControl(Control control)
        {
            if (control == null)
                return;
            control.Size = new Size(this.Width, this.Height - m_uc_offset);
            control.Location = new Point(0, m_uc_offset);
            control.BringToFront();
        }

        private void m_btn_hgplan_Click(object sender, EventArgs e)
        {
            if (m_ctl_hgplan == null) {
                m_ctl_hgplan = new HGPlan();                
                this.Controls.Add(m_ctl_hgplan);
            }
            BringToFrontUserControl(m_ctl_hgplan);
            ButtonExChecked(m_btn_hgplan);
        }

        private void m_btn_material_Click(object sender, EventArgs e)
        {
            if (m_ctl_material == null)
            {
                m_ctl_material = new Material();
                this.Controls.Add(m_ctl_material);
            }
            BringToFrontUserControl(m_ctl_material);
            ButtonExChecked(m_btn_material);
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
            
            //string strURL = "https://edutest.hongkazhijia.com/platform/login/getImage";
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

            // HGRestfulAPI.getInstance().getHGComCategory();
            // {""id"":1,""key"":"""",""albumType"":2,""startTime"":1521738981174,""endTime"":1541738981174,""sliceParams"": {""pageNum"": 1, ""pageSize"": 10}}";
            // HGRestfulAPI.getInstance().getHGAlbum(1, "", 2, 1521738981174, 1541738981174, 1, 10);
            
            //HGRestfulAPI.getInstance().uploadHGFile(@"D:\zhangguixin\myapps\HGSystem\res\minimize.png");

        }

        private void m_btn_content_Click(object sender, EventArgs e)
        {
            if (m_ctl_contentpublish == null)
            {
                m_ctl_contentpublish = new ContentPublish();
                this.Controls.Add(m_ctl_contentpublish);
            }
            BringToFrontUserControl(m_ctl_contentpublish);
            ButtonExChecked(m_btn_content);
        }

        private void m_btn_profile_Click(object sender, EventArgs e)
        {
            // HGAlbum hga = HGRestfulAPI.getInstance().getHGAlbum(1, "", 1, 1, 1, 1, 1);
            try
            {
                // bool newOK = HGRestfulAPI.getInstance().newHGAlbum();
                // bool newOK = HGRestfulAPI.getInstance().newHGProgram();
                HGRestfulAPI.getInstance().uploadHGFile(@"D:\zhangguixin\myapps\HGSystem\res\close.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

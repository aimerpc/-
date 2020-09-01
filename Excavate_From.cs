using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using 工作工具库.File_Operation;

namespace 网络搜索词挖掘软件
{

 
    
    public partial class Excavate_Form : Form
    {
        private delegate void ControlChange(ListViewItem lv);
        private ControlChange controlChange;
        FileCRUD fileCRUD = new FileCRUD();
        public Excavate_Form()
        {
            InitializeComponent();
            controlChange = new ControlChange(ListViewAdd);
        }
        public void GetHtml(object url)
        {
            
            
          
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            //Result_ListView.Clear();
            Thread th = new Thread(DataRead);
            th.IsBackground = true;
            th.Start();

        }
        private void DataRead()
        {
            
            string KeyWord = this.txt_KeyWord.Text;
            string url = "https://data.chinaz.com/keyword/allindex/" + KeyWord;
            string html = GetHttpWebRequest(url);
            //MessageBox.Show(html);
            fileCRUD.Write("InNetwork.html", html);
            //WebBrowser br = new WebBrowser();
            //br.Navigate("about:blank");
            //br.ScriptErrorsSuppressed = true;
            //HtmlDocument document = br.Document.OpenNew(true);
            //document.Write(html);
            // this.ItHtml(document);
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);
            for (int i = 1; i <= 50; i++)
            {
                string Xpath_Title = "//*[@id='pagedivid']/ul[" + i + "]/li[2]/a";
                string Xpath_SearchNumber = "//*[@id='pagedivid']/ul[" + i + "]/li[9]";
                string Search_Title = htmlDocument.DocumentNode.SelectSingleNode(Xpath_Title).Attributes["title"].Value;
                string Search_SearchNumber = htmlDocument.DocumentNode.SelectSingleNode(Xpath_SearchNumber).InnerText;
                ListViewItem lv = new ListViewItem(i.ToString());
                lv.SubItems.Add(Search_Title);
                lv.SubItems.Add(Search_SearchNumber);
                ListViewAdd(lv);


            }

        }
        private void ListViewAdd(ListViewItem lv)
        {
            if(Result_ListView.InvokeRequired)
            {
                Result_ListView.Invoke(controlChange, lv);

            }
            else
            {
                Result_ListView.Items.Add(lv);
            }
        }
        //public void ItHtml(HtmlDocument document)
        //{
        //    HtmlElementCollection collection = document.GetElementsByTagName("table");
        //    HtmlElement doc = collection[0];
        //    HtmlElementCollection c = doc.GetElementsByTagName("tr");
        //    fileCRUD.Write("Intework.html", doc.OuterHtml);
        //}
        private string GetHttpWebRequest(string url)
        {
            Uri uri = new Uri(url);
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(uri);
            myReq.UserAgent = "User Agent:Mozilla/4.0 (compatible;MSIE 6.0:Windows NT 5.2;.NET CLR 1.0.3705";
            myReq.Proxy = null;
            myReq.Accept = "*/*";
            myReq.KeepAlive = true;
            myReq.Headers.Add("Accept-Language", "zh-cn,en-us;q=0.5");
            HttpWebResponse result = (HttpWebResponse)myReq.GetResponse();
            Stream receviceStream = result.GetResponseStream();
            StreamReader readerOfStream = new StreamReader(receviceStream, System.Text.Encoding.GetEncoding("utf-8"));
            string strHTML = readerOfStream.ReadToEnd();
            readerOfStream.Close();
            readerOfStream.Close();
            result.Close();
            return strHTML;
        }
    }
}

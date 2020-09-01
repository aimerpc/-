using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace 网络搜索词挖掘软件
{
    class HttpRequest
    {
        public HttpWebRequest request { get; set; }
        public HttpWebResponse response { get; set; }

        public HttpRequest(string url)
        {
            this.request = (HttpWebRequest)WebRequest.Create(url);
            this.request.Method = "GET";
            this.request.ContentType = "text/xml;charset=UTF-8";
            this.request.Proxy = null;
        }
        public string GetHtml()
        {
            try
            {
                this.response = (HttpWebResponse)this.request.GetResponse();
            }
            catch(WebException ex)
            {
                this.response = (HttpWebResponse)ex.Response;
            }
           
            
            Stream stream = this.response.GetResponseStream();

            using (StreamReader sr = new StreamReader(stream, Encoding.UTF8)) 
            {
                return sr.ReadToEnd();
            }
            
            


        }
    }
}

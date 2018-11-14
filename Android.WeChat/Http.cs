using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Android.WeChat
{
    public static class Http
    {
        public static string Post(string Url,string postData) {
            var request = (HttpWebRequest)WebRequest.Create(Url);
            //var postData = "thing1=hello";
            //postData += "&thing2=world";
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString.ToString();
        }

        public static string Post(string Url)
        {
            var request = (HttpWebRequest)WebRequest.Create(Url);
            //var postData = "thing1=hello";
            //postData += "&thing2=world";
            var data = Encoding.ASCII.GetBytes("");

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString.ToString();
        }
    }
}

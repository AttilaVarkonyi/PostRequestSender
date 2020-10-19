using System;
using System.Net;
using System.Text;  // for class Encoding
using System.IO;    // for StreamReade

namespace PostRequestSender
{
    class PostRequestString
    {
        public static string PostRequest(string url, string inputString)
        {
            var request = (System.Net.HttpWebRequest)WebRequest.Create(url);

            var postData = "inputString=" + Uri.EscapeDataString(inputString); //Request handler variable name, variable value
            
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

            return responseString;
        }
    }
}

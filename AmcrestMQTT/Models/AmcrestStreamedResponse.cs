using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmcrestMQTT.Models
{
    internal class AmcrestStreamedResponse 
    {
     
        public static async Task<AmcrestStreamedResponse> Parse (StreamReader sr)
        {
            var ret = new AmcrestStreamedResponse ();
            ret.ContentType= await sr.ReadLineAsync();
            var contentLengthText = await sr.ReadLineAsync();
            if (contentLengthText == null)
                throw new ApplicationException("The response didn't receive the Content-Length");

            var dummy = sr.ReadLine();
            if (dummy   !="")
                throw new ApplicationException("Expected empty line");

            ret.ContentLength= int.Parse(contentLengthText.Split(':')[1]);
            var  chars = new char[ret.ContentLength];
            sr.Read(chars, 0, chars.Length);


            StringBuilder sb = new StringBuilder();
  
            foreach (var c in chars)
            {
                if (c == ';')
                {
                    var t = sb.ToString();
                    var parts2 = t.Split('=');
                    
                    if (t.StartsWith("Code"))
                        ret.Code = parts2[1];
                    
                    if (t.StartsWith("action"))
                        ret.Action = parts2[1];
                    
                    if (t.StartsWith("index"))
                        ret.Index = int.Parse(parts2[1]);
                    
                    if (t.StartsWith("data")) //it should mnever run this. becasue of the number of ;
                        ret.Data = parts2[2];

                    sb.Clear();
                    continue;
                }
                sb.Append(c);
            }
            if (sb.Length > 0)
            {
                var t = sb.ToString();
                var parts2 = t.Split('=');
                if (t.StartsWith("data"))
                {
                    ret.Data = parts2[1];
                }
            }

            ret.Content = new String(chars);
            


            return ret;
        }

        public string ContentType { get; set; }
        public int ContentLength { get; set; }

        public string Code { get; set; }
        public string Action { get; set; }
        public int Index { get; set; }
        public string Data { get; set; }
        public string  Content { get; set; }

        public T GetData<T>() 
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(this.Data);
        }

    }
}

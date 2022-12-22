using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LianJia_Spider
{
    public class GetSourceCode
    {
        public static string DownloadCode(string URL)
        {
            string stringWebSource;
            //创建web服务器的请求
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36";


            //获得Web服务器的响应
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            //查看网页的响应，如果StatusCode!=200就返回null！
            if (httpWebResponse.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            //获得网页的返回流
            Stream wangyeyuanma = httpWebResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(wangyeyuanma);

            //读取流中的数据并转化为string
            stringWebSource = streamReader.ReadToEnd();
            return stringWebSource;
        }

        //internal static void DownloadCode()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

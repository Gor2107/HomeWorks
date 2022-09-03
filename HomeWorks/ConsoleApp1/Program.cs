using System;
using System.Linq;
using System.Collections;
using System.Net;
using System.Xml;
using System.IO;

interface IInt
{
    void method();
}
enum MyEnum
{
    one,two, three
}

class MySTr : IInt
{
    public void method() { Console.WriteLine("asasas"); }
}
class Program
{
    public static void InvokeService(int a, int b)
    {
        //Calling CreateSOAPWebRequest method    
        HttpWebRequest request = CreateSOAPWebRequest();

        XmlDocument SOAPReqBody = new XmlDocument();
        //SOAP Body Request    
        SOAPReqBody.LoadXml(@"<?xml version=
      
         1.0
      
          encoding=
      
         utf-8
      
         ?>   < soap: Envelope xmlns: soap = ""  
      
         http: //schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">    

         < soap: Body >
      
         < Addition xmlns = ""
      
         http: //tempuri.org/"">    

         < a > " + a + @" < / a >   < b > " + b + @" < / b >   < / Addition >   < / soap:Body >   < / soap:Envelope > ");    



   using (Stream stream = request.GetRequestStream())
        {
            SOAPReqBody.Save(stream);
        }
        //Geting response from request    
        using (WebResponse Serviceres = request.GetResponse())
        {
            using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
            {
                //reading stream    
                var ServiceResult = rd.ReadToEnd();
                //writting stream result on console    
                Console.WriteLine(ServiceResult);
                Console.ReadLine();
            }
        }
    }
    public static HttpWebRequest CreateSOAPWebRequest()
    {
        //Making Web Request    
        HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"http://api.cba.am/exchangerates.asmx?op=ExchangeRatesByDate");
        //SOAPAction    
        Req.Headers.Add(@"SOAPAction:http://api.cba.am/exchangerates.asmx?op=ExchangeRatesByDate");
        //Content_type    
        Req.ContentType = "text/xml;charset=\"utf-8\"";
        Req.Accept = "text/xml";
        //HTTP method    
        Req.Method = "POST";
        //return HttpWebRequest    
        return Req;
    }
    public static void Main(string[] args)
    {
        InvokeService(1,2);
        Console.ReadLine();

    }
}




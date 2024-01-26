using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace adsdaasdaddasdsamrnjau
{
    /// <summary>
    /// Summary description for Serve
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Serve : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int Saberi(int a, int b)
        {
            return a+b;
        }

        string[] cirilica = { "а", "б", "в", "г", "д", "ђ", "е", "ж", "з", "и", "ј", "к","л", "Л", "љ", "м", "н", "њ", "о", "п", "р", "с", "т", "ћ", "у", "ф", "х", "c", "ч", "џ", "ш", "А", "Б", "В", "Г", "Д", "Ђ", "Е", "Ж", "З", "И", "Ј", "К", "Љ", "М", "Н", "Њ", "О", "П", "Р", "С", "Т", "Ћ", "У", "Ф", "Х", "Ц", "Ч","Џ", "Ш" };
        string[] latinica = { "a", "b", "v", "g", "d", "đ", "e", "ž", "z", "i", "j","k","l","L", "lj", "m", "n", "nj", "o", "p", "r", "s", "t", "ć", "u", "f", "h", "C", "č", "dž", "š", "A", "B", "V", "G", "D", "Đ", "E", "Ž", "Z", "I", "J", "K", "Lj", "M", "N", "Nj", "O", "P", "R", "S", "T", "Ć", "U", "F", "H", "C", "Č", "Dž", "Š" };

        [WebMethod]
        public string CirilicaULatinicu(string text)
        {
            int i;
            for (i = 0; i < 59; i++)
            {
                text = text.Replace( cirilica[i], latinica[i]);
            }
            return text;
        }
        [WebMethod]

        public string LatinicaUcirilicu(string text)
        {
            int i;
            for (i = 0; i < 59; i++)
            {
                text = text.Replace(latinica[i],cirilica[i]);
            }
            text = text.Replace("лј", "љ").Replace("нј", "њ").Replace("дж", "џ").Replace("Лј", "Љ").Replace("Нј", "њ").Replace("Дж", "Џ");
            return text;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class ListValuta
    {
        List<string> list;
        public ListValuta()
        {
            list = new List<string>();                          
            list.Add("GBP");
            list.Add("EUR");
            list.Add("USD");
            list.Add("DKK");
            list.Add("NOK");
            list.Add("");
            list.Add("AUD");
            list.Add("BRL");
            list.Add("CAD");
            list.Add("CHF");
            list.Add("CNY");
            list.Add("CZK");
            list.Add("HKD");
            list.Add("HUF");
            list.Add("IDR");
            list.Add("INR");
            list.Add("ISK");
            list.Add("JPY");
            list.Add("KRW");
            list.Add("MAD");
            list.Add("MXN");
            list.Add("NZD");
            list.Add("PLN");
            list.Add("RUB");
            list.Add("SAR");
            list.Add("SGD");
            list.Add("THB");
            list.Add("TRY");
            list.Add("ZAR");
        }
        public string[] Output()
        {
            return list.ToArray();
        }
    }
}

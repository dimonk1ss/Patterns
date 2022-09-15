using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9Composit
{
    public class ChangebleCoin : CryptoCurrency
    {
        private string _name;
        private long _price_in_usd;
        private string _code;
        public ChangebleCoin(string name, long price_in_usd, string code)
        {
            _name = name;
            _price_in_usd = price_in_usd;
            _code = code;
        }

        public override string ConverttoString()
        {
            string txt = string.Empty;
            txt += $"{_name} : {_price_in_usd}\n{_code}";
            return txt;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{_name} : {_price_in_usd} \n {_code}");
        }

    }
}

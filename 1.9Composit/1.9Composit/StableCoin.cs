using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9Composit
{
    public class StableCoin : CryptoCurrency
    {
        private string _name;
        private string _currency_that_stables_coin;
        private string _code;
        public StableCoin(string name, string currency_that_stables_coin, string code)
        {
            _name = name;
            _currency_that_stables_coin = currency_that_stables_coin;
            _code = code;

        }
        public override string ConverttoString()
        {
            string txt = string.Empty;
            txt += $"{_name} : {_currency_that_stables_coin}\n{_code}";
            return txt;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{_name} : {_currency_that_stables_coin} \n {_code}");
        }
    }
}

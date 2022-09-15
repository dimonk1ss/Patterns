using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9Composit
{
    public class CryptoWallet : CryptoCurrency
    {
        private List<CryptoCurrency> _CryptoCurrencies = new List<CryptoCurrency>();
        public override void ShowInfo()
        {
            foreach (CryptoCurrency CryptoCurrency in _CryptoCurrencies)
                CryptoCurrency.ShowInfo();
        }
        public void Add(CryptoCurrency CryptoCurrency)
        {
            _CryptoCurrencies.Add(CryptoCurrency);
        }
        public void Delete(CryptoCurrency CryptoCurrency)
        {
            _CryptoCurrencies.Remove(CryptoCurrency);
        }

        public void PrintinFile()
        {
            using (StreamWriter writer = new StreamWriter("file.txt"))
            {
                foreach(CryptoCurrency CryptoCurrency in _CryptoCurrencies)
                {
                    writer.WriteLine(CryptoCurrency.ConverttoString());
                }
            }
        }

        public override string ConverttoString()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
namespace _1._9Composit
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChangebleCoin bitcoin = new ChangebleCoin("Bitcoin", 19816, "66925f1da83c54354da73d81e013974d");
            ChangebleCoin ethereum = new ChangebleCoin("Ethereum", 1500, "f8f8a2f43c8376ccb0871305060d7b27b0554d2cc72bccf41b2705608452f315");

            StableCoin tether = new StableCoin("USDTether", "1 USD", "bd9520b9aea701e9606ad8a8f4d6852d70f2013b12df19b6d58147038392354e");
            StableCoin binanceusd = new StableCoin("BinanceUSD", "1 USD", "172ef2e238226a5ebf442501fec74e34");

            CryptoWallet OKX = new CryptoWallet();
            OKX.Add(bitcoin);
            OKX.Add(ethereum);
            OKX.Add(tether);
            OKX.Add(binanceusd);
            OKX.ShowInfo();
            OKX.PrintinFile();
        }
    }
}

using Faker.Locales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public class Finance : FakerBase
    {
        public Finance() : this(LocaleType.en) { }
        public Finance(LocaleType type) : base(type) { this.factory = new Random.RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Finance Default { get { return defaultValue; } }
        private static Finance defaultValue = new Finance();

        private Random.RandomFactory factory;

        public string GetAccountName()
        {
            return factory.Next<string>(Random.Selector.GetRandomItemFromList<string>(locale.AccountTypeFormat));
        }

        public string GetAccount()
        {
            return this.GetAccount(8);
        }

        public string GetAccount(int length)
        {
            string format = new string('#', length);
            return factory.Next<string>(format, Random.FormatType.Number);
        }

        public string GetAmount(decimal min, decimal max)
        {
            return this.GetAmount(min, max, 2, "");
        }

        public string GetAmount(decimal min, decimal max, int decimalPlace, string symbol)
        {
            return symbol + Decimal.Round(Random.RandomProxy.Next(min, max), decimalPlace).ToString();
        }

        public string GetTransactionType()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.TransactionType);
        }

        public string GetCurrencyName()
        {
            return Random.Selector.GetRandomKeyFromDictionary<string, Object>(locale.Currency);
        }

        public string GetCurrencyCode()
        {
            string randomKey = GetCurrencyName();
            dynamic dic = locale.Currency[randomKey];
            return dic["code"];
        }

        public string GetCurrencySymbol()
        {
            string symbol = "";
            while (string.IsNullOrWhiteSpace(symbol))
            {
                string randomKey = GetCurrencyName();
                dynamic dic = locale.Currency[randomKey];
                symbol = dic["symbol"];
            }
            return symbol;
        }
    }
}

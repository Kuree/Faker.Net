using System;
using Faker.Random;

namespace Faker
{
    public class Finance : FakerBase
    {
        public Finance() : this(LocaleType.en) { }
        public Finance(LocaleType type) : base(type) { this.factory = new RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Finance Default { get { return defaultValue; } }
        private static Finance defaultValue = new Finance();

        private RandomFactory factory;

        public string GetAccountName()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList(locale.AccountTypeFormat));
        }

        public string GetAccount()
        {
            return this.GetAccount(8);
        }

        public string GetAccount(int length)
        {
            string format = new string('#', length);
            return factory.Next<string>(format, FormatType.Number);
        }

        public string GetAmount(decimal min, decimal max)
        {
            return this.GetAmount(min, max, 2, "");
        }

        public string GetAmount(decimal min, decimal max, int decimalPlace, string symbol)
        {
            return symbol + Decimal.Round(RandomProxy.Next(min, max), decimalPlace);
        }

        public string GetTransactionType()
        {
            return Selector.GetRandomItemFromList(locale.TransactionType);
        }

        public string GetCurrencyName()
        {
            return Selector.GetRandomKeyFromDictionary(locale.Currency);
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

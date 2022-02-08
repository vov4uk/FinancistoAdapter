﻿using Financier.Common.Utils;
using Financier.DataAccess.Data;

namespace Financier.Common.Model
{
    public class AccountModel : AccountFilterModel
    {
        public long LastTransactionDate { get; set; }

        public bool IsIncludeIntoTotals { get; set; } = true;

        public CurrencyModel Currency { get; set; }

        public string AmountTitle => BlotterUtils.SetAmountText(Currency, TotalAmount, false);

        public AccountModel() { }

        public AccountModel(Account acc)
        {
            Id = acc.Id;
            Title = acc.Title;
            CurrencyId = acc.CurrencyId;
            Is_Active = acc.IsActive ? 1 : 0;
            IsIncludeIntoTotals = acc.IsIncludeIntoTotals;
            LastTransactionDate = acc.LastTransactionDate;
            SortOrder = acc.SortOrder;
            TotalAmount = acc.TotalAmount;
            Type = acc.Type;
            Currency = acc.Currency  != null ? new CurrencyModel(acc.Currency) : default;
        }
    }
}

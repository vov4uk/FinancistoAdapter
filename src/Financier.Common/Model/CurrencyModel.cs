﻿using Financier.DataAccess.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financier.Common.Model
{
    public class CurrencyModel : BaseModel
    {
        [Column("_id")]
        public long? Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("symbol")]
        public string Symbol { get; set; }

        [Column("is_default")]
        public long IsDefault { get; set; }

        public CurrencyModel() { }

        public CurrencyModel(Currency currency)
        {
            Id = currency.Id;
            IsDefault = currency.IsDefault ? 1 : 0;
            Name = currency.Name;
            Title = currency.Title;
            Symbol = currency.Symbol;
        }
    }
}
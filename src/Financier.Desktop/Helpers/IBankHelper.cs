﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Financier.Desktop.Wizards;

namespace Financier.Desktop.Helpers
{
    public interface IBankHelper
    {
        string BankTitle { get; }
        Task<IEnumerable<BankTransaction>> ParseReport(string filePath);
    }
}

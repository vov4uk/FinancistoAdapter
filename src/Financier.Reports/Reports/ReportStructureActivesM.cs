﻿using Financier.Reports.Common;
using System.ComponentModel;

namespace Financier.Reports.Reports
{
    public class ReportStructureActivesM : BaseReportM
    {
        [Field("title")]
        [DisplayName("Актив")]
        public string Name { get; protected set; }

        [Field("total")]
        [DisplayName("Сумма")]
        public double? Total { get; protected set; }
    }
}
﻿using System.ComponentModel;

namespace fcrd
{
    public class ReportStructureDebitM : BaseReportM
    {
        [Field("title")]
        [DisplayName("Получатель")]
        public string Name { get; protected set; }

        [Field("total")]
        [DisplayName("Сумма")]
        public double? Total { get; protected set; }
    }
}
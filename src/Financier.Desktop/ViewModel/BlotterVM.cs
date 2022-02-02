﻿namespace Financier.Desktop.ViewModel
{
    using Financier.DataAccess.View;
    using Prism.Commands;
    using System;
    using System.Collections.Generic;

    public class BlotterVM : EntityBaseVM<BlotterTransactions>
    {
        public BlotterVM(IEnumerable<BlotterTransactions> items) : base(items) {}

        private DelegateCommand _addTemplateCommand;

        private DelegateCommand _addTransferCommand;

        private DelegateCommand _duplicateCommand;

        private DelegateCommand _infoCommand;

        public event EventHandler AddTemplateRaised;

        public event EventHandler AddTransferRaised;

        public event EventHandler<TransactionsView> DuplicateRaised;

        public event EventHandler<TransactionsView> InfoRaised;

        public DelegateCommand AddTemplateCommand => _addTemplateCommand ??= new DelegateCommand(() => AddTemplateRaised?.Invoke(this, EventArgs.Empty), () => false);

        public DelegateCommand AddTransferCommand => _addTransferCommand ??= new DelegateCommand(() => AddTransferRaised?.Invoke(this, EventArgs.Empty));

        public DelegateCommand DuplicateCommand => _duplicateCommand ??= new DelegateCommand(() => DuplicateRaised?.Invoke(this, SelectedValue), () => false);

        public DelegateCommand InfoCommand => _infoCommand ??= new DelegateCommand(() => InfoRaised?.Invoke(this, SelectedValue), () => false);
    }
}

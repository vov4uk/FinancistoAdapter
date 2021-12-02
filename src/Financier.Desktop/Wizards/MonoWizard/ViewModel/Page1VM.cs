﻿using Financier.DataAccess.Data;
using Financier.Desktop.MonoWizard.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Financier.Desktop.Wizards.MonoWizard.ViewModel
{
    public class Page1VM : WizardPageBaseVM
    {

        private ObservableCollection<Account> _accounts;

        private Account _monoAccount;

        public Page1VM(List<Account> records)
        {
            _accounts = new ObservableCollection<Account>(records);
            _monoAccount = _accounts?.FirstOrDefault(x => x.IsActive && x.Title.Contains("mono", System.StringComparison.OrdinalIgnoreCase));
        }
        public ObservableCollection<Account> Accounts
        {
            get => _accounts;
            set
            {
                _accounts = value;
                RaisePropertyChanged(nameof(Accounts));
            }
        }
        public Account MonoAccount
        {
            get => _monoAccount;
            set
            {
                _monoAccount = value;
                RaisePropertyChanged(nameof(MonoAccount));
            }
        }

        public override string Title => "Please select account";

        public override bool IsValid()
        {
            return MonoAccount != null;
        }
    }
}

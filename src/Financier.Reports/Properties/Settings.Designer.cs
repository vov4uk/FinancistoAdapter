﻿using System.Configuration;
using System.Diagnostics;

namespace Financier.Reports.Reports.Properties
{
    internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }

    [DefaultSettingValue("..\\..\\..\\DCDataBackup")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string LastBackupDir
    {
      get => (string) this[nameof (LastBackupDir)];
      set => this[nameof (LastBackupDir)] =  value;
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool MondayFirstDay
    {
      get => (bool) this[nameof (MondayFirstDay)];
      set => this[nameof (MondayFirstDay)] =  value;
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool AutoDataLoad
    {
      get => (bool) this[nameof (AutoDataLoad)];
      set => this[nameof (AutoDataLoad)] =  value;
    }
  }
}
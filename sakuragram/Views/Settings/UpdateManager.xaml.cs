﻿using Windows.Storage;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using TdLib;

namespace sakuragram.Views.Settings;

public partial class UpdateManager : Page
{
    private static TdClient _client = App._client;
    private ApplicationDataContainer _localSettings = ApplicationData.Current.LocalSettings;
    
    public UpdateManager()
    {
        InitializeComponent();
        
        System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
        System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
        string version = fvi.FileVersion;
        
        TextBlockVersionInfo.Text = $"Current version: {version}, TDLib 1.8.29";

        #region Settings

        if (_localSettings != null)
        {
            if (_localSettings.Values["AutoUpdate"] != null)
            {
                bool autoUpdateValue = (bool)_localSettings.Values["AutoUpdate"];
                ToggleSwitchAutoUpdate.IsOn = autoUpdateValue;
            }
            else
            {
                ToggleSwitchAutoUpdate.IsOn = true;
                _localSettings.Values["AutoUpdate"] = true;
            }
        
            if (_localSettings.Values["InstallBeta"] != null)
            {
                bool installBetaValue = (bool)_localSettings.Values["InstallBeta"];
                ToggleSwitchInstallBeta.IsOn = installBetaValue;
            }
            else
            {
                ToggleSwitchInstallBeta.IsOn = false;
                _localSettings.Values["InstallBeta"] = false;
            }
        }

        #endregion
    }

    private void ButtonCheckForUpdates_OnClick(object sender, RoutedEventArgs e)
    {
    }

    #region setting parameters

    private void ToggleSwitch_OnToggled(object sender, RoutedEventArgs e)
    {
        _localSettings.Values["InstallBeta"] = ToggleSwitchInstallBeta.IsOn;
    }

    private void ToggleSwitchAutoUpdate_OnToggled(object sender, RoutedEventArgs e)
    {
        _localSettings.Values["AutoUpdate"] = ToggleSwitchAutoUpdate.IsOn;
    }

    #endregion
}
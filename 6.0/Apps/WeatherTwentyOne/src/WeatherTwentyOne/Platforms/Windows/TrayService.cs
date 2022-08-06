﻿using Hardcodet.Wpf.TaskbarNotification.Interop;
using Microsoft.UI.Xaml;
using WeatherDataService.Services;

namespace WeatherTwentyOne.WinUI;

public class TrayService : ITrayService
{
    WindowsTrayIcon tray;

    public Action ClickHandler { get; set; }

    public void Initialize()
    {
        tray = new WindowsTrayIcon("Platforms/Windows/trayicon.ico");
        tray.LeftClick = () => {
            WindowExtensions.BringToFront();
            ClickHandler?.Invoke();
        };
    }
}

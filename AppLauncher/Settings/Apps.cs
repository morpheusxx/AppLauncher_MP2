﻿#region Copyright (C) 2007-2014 Team MediaPortal

/*
    Copyright (C) 2007-2014 Team MediaPortal
    http://www.team-mediaportal.com

    This file is part of MediaPortal 2

    MediaPortal 2 is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    MediaPortal 2 is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MediaPortal 2. If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Collections.Generic;
using MediaPortal.Common.Settings;

namespace AppLauncher.Settings
{
  public class Apps
  {
    public Apps()
    {
      AppsList = new List<App>();
    }

    public Apps(List<App> appList)
    {
      AppsList = appList;
    }

    /// <summary>
    /// List of all Apps
    /// </summary>
    [Setting(SettingScope.User, null)]
    public List<App> AppsList { get; set; }
  }

  public class App
  {
    public App()
    {
      ShortName = string.Empty;
      ApplicationPath = string.Empty;
      Arguments = string.Empty;
      Description = string.Empty;
      Username = string.Empty;
      Password = string.Empty;
      IconPath = string.Empty;
      ScreenMode = string.Empty;
      Id = string.Empty;
      Admin = false;
    }

    /// <summary>
    /// ShortName
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string ShortName { get; set; }

    /// <summary>
    /// ApplicationPath
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string ApplicationPath { get; set; }

    /// <summary>
    /// Application Arguments
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string Arguments { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string Description { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string Username { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string Password { get; set; }

    /// <summary>
    /// IconPath
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string IconPath { get; set; }

    /// <summary>
    /// ScreenMode
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string ScreenMode { get; set; }

    /// <summary>
    /// Application Id
    /// </summary>
    [Setting(SettingScope.User, "")]
    public string Id { get; set; }

    /// <summary>
    /// run as Admin
    /// </summary>
    [Setting(SettingScope.User, false)]
    public bool Admin { get; set; }
  }
}
﻿using PluginFramework;

namespace Plugin_DbManager
{
    public class PluginSetting : IPluginSetting
    {
        public bool IsAutoLoad
        {
            get { return false; }
        }

        public bool IsNeedShellData
        {
            get { return true; }
        }

        public bool IsShowInRightContext
        {
            get { return true; }
        }
    }
}

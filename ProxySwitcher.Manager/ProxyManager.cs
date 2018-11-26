using Microsoft.Win32;
using ProxySwitcher.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.Manager
{
    public class ProxyManager
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;

        private readonly RegistryKey _registry;

        public ProxyManager()
        {
            _registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        }

        public void ConnectToProxy(ProxySettingDto proxy)
        {
            if (!string.IsNullOrEmpty(proxy.Script))
            {
                _registry.SetValue("AutoConfigURL", proxy.Script);
                _registry.SetValue("ProxyEnable", 0);
            }
            else
            {
                _registry.SetValue("ProxyServer", $"{proxy.IpAddress}:{proxy.Port}");
                _registry.SetValue("ProxyEnable", 1);
            }
            RefreshProxyChange();
        }

        public void DisconnectFromProxy()
        {
            _registry.SetValue("ProxyEnable", 0);
            RefreshProxyChange();
        }

        private void RefreshProxyChange()
        {
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
    }
}

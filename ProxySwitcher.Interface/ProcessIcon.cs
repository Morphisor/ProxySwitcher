using ProxySwitcher.Interface.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcher.Interface
{
    public class ProcessIcon : IDisposable
    {
        private readonly NotifyIcon _notifyIcon;

        public ProcessIcon()
        {
            _notifyIcon = new NotifyIcon();
        }

        public void Display()
        {
            _notifyIcon.Icon = Resources.TrayIcon;
            _notifyIcon.Text = "Proxy switcher";
            _notifyIcon.Visible = true;

            _notifyIcon.ContextMenuStrip = new ContextMenus().Create();
        }

        public void Dispose()
        {
            _notifyIcon.Dispose();
        }
    }
}

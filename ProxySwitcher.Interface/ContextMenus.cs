using ProxySwitcher.DataAccess.Services;
using ProxySwitcher.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcher.Interface
{
    public class ContextMenus
    {
        private readonly ProxyManager _proxyManager;
        private readonly ProxySettingService _proxySettingService;
        private ContextMenuStrip menu;

        public ContextMenus()
        {
            _proxyManager = new ProxyManager();
            _proxySettingService = new ProxySettingService();
        }

        public ContextMenuStrip Create()
        {
            menu = new ContextMenuStrip();
            AddProxies();
            AddDefaultMenuEntries();
            return menu;
        }

        private void RefreshProxyList()
        {
            menu.Items.Clear();
            AddProxies();
            AddDefaultMenuEntries();
        }

        private void AddProxies()
        {
            var proxyList = _proxySettingService.GetAll();
            foreach (var proxy in proxyList)
            {
                var item = new ToolStripMenuItem();
                item.Text = proxy.Name;
                item.Click += onProxyClick;
                menu.Items.Add(item);
            }
        }

        private void AddDefaultMenuEntries()
        {
            menu.Items.Add(new ToolStripSeparator());
            var item = new ToolStripMenuItem();
            item.Text = "Disconnect";
            item.Click += onDisconnect;
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "Manage Proxies";
            item.Click += onClickManage;
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += onClickExit;
            menu.Items.Add(item);
        }

        private void UncheckAllItems()
        {
            foreach (var item in menu.Items)
            {
                if (item is ToolStripMenuItem)
                {
                    var mItem = (ToolStripMenuItem)item;
                    mItem.Checked = false;
                }
            }
        }

        private void onProxyClick(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            UncheckAllItems();
            menuItem.Checked = true;
            var proxy = _proxySettingService.Get(prx => prx.Name == menuItem.Text).First();
            _proxyManager.ConnectToProxy(proxy);
        }

        private void onDisconnect(object sender, EventArgs e)
        {
            _proxyManager.DisconnectFromProxy();
            UncheckAllItems();
        }

        private void onClickManage(object sender, EventArgs e)
        {
            new ManageProxy().ShowDialog();
            RefreshProxyList();
        }

        private void onClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

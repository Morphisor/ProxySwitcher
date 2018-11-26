using ProxySwitcher.DataAccess.Services;
using ProxySwitcher.Interface.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcher.Interface
{
    public partial class ManageProxy : Form
    {
        private readonly ProxySettingService _proxySettingService;

        public ManageProxy()
        {
            InitializeComponent();
            _proxySettingService = new ProxySettingService();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Icon = Resources.TrayIcon;
        }

        protected override void OnLoad(EventArgs e)
        {
            ProxyList.MultiSelect = false;
            LoadProxyList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new ProxyEditor().ShowDialog();
            LoadProxyList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (ProxyList.SelectedItems.Count > 0)
            {
                var selectedItem = ProxyList.SelectedItems[0];
                var proxyId = int.Parse(selectedItem.SubItems[4].Text);
                new ProxyEditor(proxyId).ShowDialog();
                LoadProxyList();
            }
        }

        private void LoadProxyList()
        {
            var proxyList = _proxySettingService.GetAll();
            ProxyList.Items.Clear();
            foreach (var proxy in proxyList)
            {
                var viewItem = new ListViewItem(proxy.Name);
                viewItem.SubItems.Add(proxy.IpAddress);
                viewItem.SubItems.Add(proxy.Port.ToString());
                viewItem.SubItems.Add(proxy.Script);
                viewItem.SubItems.Add(proxy.ProxySettingId.ToString());
                ProxyList.Items.Add(viewItem);
            }
        }
    }
}

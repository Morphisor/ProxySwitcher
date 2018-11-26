using ProxySwitcher.DataAccess.Services;
using ProxySwitcher.Interface.Properties;
using ProxySwitcher.Models.Dtos;
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
    public partial class ProxyEditor : Form
    {
        private readonly ProxySettingService _proxySettingService;
        private readonly int? _proxyId;

        public ProxyEditor(int? proxyId = null)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            _proxySettingService = new ProxySettingService();
            _proxyId = proxyId;
            Icon = Resources.TrayIcon;
            if (_proxyId.HasValue)
                LoadExistingProxy();
        }

        private void LoadExistingProxy()
        {
            var proxyDto = _proxySettingService.Get(proxy => proxy.ProxySettingId == _proxyId.Value).First();
            ProxyNameTxt.Text = proxyDto.Name;
            IpAddressTxt.Text = proxyDto.IpAddress;
            PortTxt.Text = proxyDto.Port.ToString();
            ScriptTxt.Text = proxyDto.Script;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var proxyToSave = new ProxySettingDto();
            proxyToSave.Name = ProxyNameTxt.Text;
            proxyToSave.IpAddress = IpAddressTxt.Text;
            proxyToSave.Port = string.IsNullOrEmpty(PortTxt.Text) ? 0 : int.Parse(PortTxt.Text);
            proxyToSave.Script = ScriptTxt.Text;

            if (_proxyId.HasValue)
            {
                proxyToSave.ProxySettingId = _proxyId.Value;
                _proxySettingService.Update(proxyToSave);
            }
            else
            {
                _proxySettingService.Insert(proxyToSave);
            }

            Close();
        }
    }
}

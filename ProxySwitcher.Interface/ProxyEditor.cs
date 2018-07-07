using ProxySwitcher.DataAccess.Services;
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

        public ProxyEditor()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            _proxySettingService = new ProxySettingService();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var ProxyToSave = new ProxySettingDto();
            ProxyToSave.CreateDate = DateTime.Now;
            ProxyToSave.Name = ProxyNameTxt.Text;
            ProxyToSave.IpAddress = IpAddressTxt.Text;
            ProxyToSave.Port = int.Parse(PortTxt.Text);
            _proxySettingService.Insert(ProxyToSave);
            Close();
        }
    }
}

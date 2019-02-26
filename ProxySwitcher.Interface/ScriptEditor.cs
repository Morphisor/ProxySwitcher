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
    public partial class ScriptEditor : Form
    {
        private readonly ScriptSettingService _scriptSettingService;
        private readonly int? _scriptId;

        public ScriptEditor(int? scriptId = null )
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            _scriptSettingService = new ScriptSettingService();
            _scriptId = scriptId;
            Icon = Resources.TrayIcon;
            if (_scriptId.HasValue)
                LoadExistingScript();
        }

        private void LoadExistingScript()
        {
            var scriptDto = _scriptSettingService.Get(script => script.ScriptSettingId == _scriptId.Value).First();
            NameTxt.Text = scriptDto.Name;
            ScriptTxt.Text = scriptDto.Script;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var scriptToSave = new ScriptSettingDto();
            scriptToSave.Name = NameTxt.Text;
            scriptToSave.Script = ScriptTxt.Text;

            if (_scriptId.HasValue)
            {
                scriptToSave.ScriptSettingId = _scriptId.Value;
                _scriptSettingService.Update(scriptToSave);
            }
            else
            {
                _scriptSettingService.Insert(scriptToSave);
            }

            Close();
        }
    }
}

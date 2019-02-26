using ProxySwitcher.DataAccess.Services;
using ProxySwitcher.Interface.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcher.Interface
{
    public partial class ManageScript : Form
    {

        private readonly ScriptSettingService _scriptSettingService;

        public ManageScript()
        {
            InitializeComponent();
            _scriptSettingService = new ScriptSettingService();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Icon = Resources.TrayIcon;
        }

        protected override void OnLoad(EventArgs e)
        {
            ScriptList.MultiSelect = false;
            LoadScriptList();
        }

        private void LoadScriptList()
        {
            var scriptList = _scriptSettingService.GetAll();
            ScriptList.Items.Clear();
            foreach (var script in scriptList)
            {
                var viewItem = new ListViewItem(script.Name);
                viewItem.SubItems.Add(script.ScriptSettingId.ToString());
                viewItem.SubItems.Add(script.Script);
                ScriptList.Items.Add(viewItem);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new ScriptEditor().ShowDialog();
            LoadScriptList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ScriptList.SelectedItems.Count > 0)
            {
                var selectedItem = ScriptList.SelectedItems[0];
                var scriptId = int.Parse(selectedItem.SubItems[1].Text);
                new ScriptEditor(scriptId).ShowDialog();
                LoadScriptList();
            }
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            if (ScriptList.SelectedItems.Count > 0)
            {
                var selectedItem = ScriptList.SelectedItems[0];
                Process scriptProcess = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "CMD.exe";
                startInfo.Arguments = selectedItem.SubItems[2].Text;
                scriptProcess.StartInfo = startInfo;
                scriptProcess.Start();
                scriptProcess.WaitForExit();
            }
        }
    }
}

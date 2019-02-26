using ProxySwitcher.Utils.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.Models.Entities
{
    public class ScriptSetting
    {
        [SQLitePrimaryKey]
        public int ScriptSettingId { get; set; }

        public string Name { get; set; }
        public string Script { get; set; }
    }
}

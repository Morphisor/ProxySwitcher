using ProxySwitcher.Utils.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.Models.Entities
{
    public class ProxySetting
    {
        [SQLitePrimaryKey]
        public int ProxySettingId { get; set; }

        public string Name { get; set; }
        public string IpAddress { get; set; }
        public int Port { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.Models.Dtos
{
    public class ProxySettingDto
    {
        public int ProxySettingId { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

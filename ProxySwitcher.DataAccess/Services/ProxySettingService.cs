using ProxySwitcher.Models.Dtos;
using ProxySwitcher.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxySwitcher.Utils;

namespace ProxySwitcher.DataAccess.Services
{
    public class ProxySettingService : SQLiteBaseService<ProxySettingDto, ProxySetting>
    {
        public ProxySettingService() : base("PROXY_SETTINGS")
        {

        }

        internal override ProxySetting MapDtoToEntity(ProxySettingDto model)
        {
            var toReturn = new ProxySetting()
            {
                CreateDate = model.CreateDate.GetUnixTime(),
                IpAddress = model.IpAddress,
                Port = model.Port,
                Name = model.Name,
                ProxySettingId = model.ProxySettingId
            };
            return toReturn;
        }

        internal override ProxySettingDto MapEntityToDto(ProxySetting model)
        {
            var toReturn = new ProxySettingDto()
            {
                CreateDate = model.CreateDate.GetDateTime(),
                IpAddress = model.IpAddress,
                Port = model.Port,
                Name = model.Name,
                ProxySettingId = model.ProxySettingId
            };
            return toReturn;
        }
    }
}

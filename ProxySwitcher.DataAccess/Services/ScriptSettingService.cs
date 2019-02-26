using ProxySwitcher.Models.Dtos;
using ProxySwitcher.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher.DataAccess.Services
{
    public class ScriptSettingService : SQLiteBaseService<ScriptSettingDto, ScriptSetting>
    {
        public ScriptSettingService() : base("SCRIPT_SETTINGS")
        {
        }

        internal override ScriptSetting MapDtoToEntity(ScriptSettingDto model)
        {
            var toReturn = new ScriptSetting()
            {
                Name = model.Name,
                Script = model.Script,
                ScriptSettingId = model.ScriptSettingId
            };
            return toReturn;
        }

        internal override ScriptSettingDto MapEntityToDto(ScriptSetting model)
        {
            var toReturn = new ScriptSettingDto()
            {
                Name = model.Name,
                Script = model.Script,
                ScriptSettingId = model.ScriptSettingId
            };
            return toReturn;
        }
    }
}

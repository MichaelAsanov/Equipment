using System.Collections.Generic;
using Equipment.UI.Web.IO;
using Newtonsoft.Json;

namespace Equipment.UI.Web.Services
{
    /// <summary>
    /// Сервис для работы с оборудованием
    /// </summary>
    public class EquipmentService : IEquipmentService
    {
        /// <inheritdoc/>
        public IEnumerable<dynamic> GetEquipment()
        {
            var jsonedEquipment = EmbeddedFiles.GetFileContent($"{nameof(Equipment)}.{nameof(UI)}.{nameof(Web)}.MOCK_DATA.json");
            return JsonConvert.DeserializeObject<IEnumerable<dynamic>>(jsonedEquipment);
        }
    }
}

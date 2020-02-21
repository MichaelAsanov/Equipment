using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<dynamic>> GetEquipmentAsync()
        {
            var jsonedEquipment = await EmbeddedFiles.GetFileContentAsync($"{nameof(Equipment)}.{nameof(UI)}.{nameof(Web)}.MOCK_DATA.json");
            return JsonConvert.DeserializeObject<IEnumerable<dynamic>>(jsonedEquipment);
        }
    }
}

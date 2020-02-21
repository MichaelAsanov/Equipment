using System.Collections.Generic;
using System.Threading.Tasks;

namespace Equipment.UI.Web.Services
{
    /// <summary>
    /// Интерфейс сервиса для работы с оборудованием
    /// </summary>
    public interface IEquipmentService
    {
        /// <summary>
        /// Получение списка оборудования
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<dynamic>> GetEquipmentAsync();
    }
}

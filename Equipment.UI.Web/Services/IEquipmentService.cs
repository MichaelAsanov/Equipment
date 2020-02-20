using System.Collections.Generic;

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
        IEnumerable<dynamic> GetEquipment();
    }
}

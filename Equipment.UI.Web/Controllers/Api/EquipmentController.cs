using System;
using System.Linq;
using Equipment.UI.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Equipment.UI.Web.Controllers.Api
{
    /// <summary>
    /// Контроллер для оборудования
    /// </summary>
    public class EquipmentController : Controller
    {
        private readonly IEquipmentService _equipmentService;   
        
        /// <summary>
        /// Initialize instance if <see cref="EquipmentController"/>
        /// </summary>
        /// <param name="equipmentService"><see cref="IEquipmentService"/></param>
        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService ?? throw new ArgumentNullException(nameof(equipmentService));
        }
        
        /// <summary>
        /// Возвращает список оборудования
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
            return Json(_equipmentService.GetEquipment().ToList());
        }
    }
}
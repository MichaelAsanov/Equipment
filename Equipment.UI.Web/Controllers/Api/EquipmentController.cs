using System;
using System.Linq;
using Equipment.UI.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Equipment.UI.Web.Controllers.Api
{
    public class EquipmentController : Controller
    {
        private readonly IEquipmentService _equipmentService;   
        
        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService ?? throw new ArgumentNullException(nameof(equipmentService));
        }
        
        public IActionResult List()
        {
            return Json(_equipmentService.GetEquipment().ToList());
        }
    }
}
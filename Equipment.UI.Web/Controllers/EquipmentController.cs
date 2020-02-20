using System;
using Equipment.UI.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Equipment.UI.Web.Controllers
{
    public class EqipmentController : Controller
    {
        private readonly IEquipmentService _equipmentService;   
            
       
        public EqipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService ?? throw new ArgumentNullException(nameof(equipmentService));
        }
        
        public IActionResult List()
        {
            return Json(_equipmentService.GetEquipment());
        }
    }
}
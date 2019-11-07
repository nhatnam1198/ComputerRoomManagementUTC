using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Class;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Class> condition)
        {
            ClassBusiness mouseBusiness = new ClassBusiness();
            var result = mouseBusiness.GetAllClassSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddClassViewModel mouse)
        {
            ClassBusiness mouseBusiness = new ClassBusiness();
            var result = mouseBusiness.AddClass(mouse);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            ClassBusiness mouseBusiness = new ClassBusiness();
            var result = mouseBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            ClassBusiness mouseBusiness = new ClassBusiness();
            var result = mouseBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(ClassDeleteViewModel mouse)
        {
            ClassBusiness mouseBusiness = new ClassBusiness();
            var result = mouseBusiness.Delete(mouse);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(ClassEditViewModel mouse)
        {
            ClassBusiness mouseBusiness = new ClassBusiness();
            var result = mouseBusiness.Edit(mouse);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(ClassEditStatusViewModel mouse)
        {
            ClassBusiness mouseBusiness = new ClassBusiness();
            var result = mouseBusiness.EditStatus(mouse);
            return Ok(result);
        }
    }
}
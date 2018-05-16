

using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BLL;
using BLL.Entities;

namespace Web.Controllers
{
    [RoutePrefix("departament")]
    public class DepartamentController : ApiController
    {
        private readonly BasicOperationDepartament _basicOperationDepartament;
        //  private Room room;

        public DepartamentController(BasicOperationDepartament basicOperationDepartament)
        {
            _basicOperationDepartament = basicOperationDepartament;

        }
        [HttpGet]
        public IEnumerable<Departament> GetDepartaments()
        {
            return _basicOperationDepartament.GetDepartament();
        }
        [HttpPost]
        public IHttpActionResult Post(Departament departament)
        {
            
                _basicOperationDepartament.AddDepartament(departament);
            return BadRequest("Please, correct inputs");

        }
        public int Get(int id)
        {
            // room.Num = 10;
            return id;
        }
    }

}
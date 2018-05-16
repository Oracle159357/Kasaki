using System.Collections.Generic;
using AutoMapper;
using BLL.Entities;
using Kasaki;
using Kasaki.Entities;

namespace BLL
{
    //public class Configuration : NinjectModule
    //{
    //    public override void Load()
    //    {

    //        this.Bind<IUnitOfWork>().To<UnitOfWork>();
    //    }
    //}
    public class BasicOperationDepartament
    {
        private readonly UnitOfWork _uow;
        public BasicOperationDepartament(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Departament> GetDepartament()
        {
            //var places = new List<Departament>();
            //places = Mapper.Map<IEnumerable<Departament1>, List<Departament>>(_uow.Departaments.Get());
            //return places;
            return Mapper.Map<IEnumerable<Departament1>, List<Departament>>(_uow.Departaments.Get());

        }
        public Departament GetDepartamentById(int id)
        {
            //var places = new Departament();
            //places = Mapper.Map<Departament1,Departament>(_uow.Departaments.Get(x=>(x.DepPk==id)));
            //return places;
            return Mapper.Map<Departament1, Departament>(_uow.Departaments.GetOne(x => (x.DepPk == id)));

        }
        public void AddDepartament(Departament departament)
        {
            //  var uow = new UnitOfWork();
            _uow.Departaments.Create(new Departament1 { Name = departament.Name, Building = departament.Building});
            _uow.Save();
        }

        public void DeleteDepartament(int id)
        {
            _uow.Departaments.Remove(_uow.Departaments.FindById(id));
            _uow.Save();
        }
    }
}
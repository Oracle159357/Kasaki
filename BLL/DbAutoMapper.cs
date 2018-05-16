using AutoMapper;
using BLL.Entities;
using Kasaki.Entities;


namespace BLL
{
    public class DbAutoMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Departament1, Departament>();
                cfg.CreateMap<Group1, Group>();
                cfg.CreateMap<Room1, Room>();
                cfg.CreateMap<Subject1, Subject>();
                cfg.CreateMap<Lecture1, Lecture>();
                cfg.CreateMap<Teacher1, Teacher>();
                cfg.CreateMap<User1, User>();
            });

        }

    }
}
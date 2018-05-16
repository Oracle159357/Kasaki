using System.Text.RegularExpressions;
using Kasaki.Entities;

namespace Kasaki
{
    public interface IUnitOfWork
    {
        ContextRepository<User1> Users { get; }
        ContextRepository<Departament1> Departaments { get; }
        ContextRepository<Group1> Groups { get; }
        ContextRepository<Lecture1> Lectures { get; }
        ContextRepository<Room1> Rooms { get; }
        ContextRepository<Subject1> Subjects { get; }
        ContextRepository<Teacher1> Teachers { get; }
        void Save();
        void Dispose();
    }
}
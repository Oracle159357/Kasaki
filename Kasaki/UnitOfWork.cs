using System;
using Kasaki.Entities;

namespace Kasaki
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly RozkladContext _db;

        public UnitOfWork(RozkladContext db, ContextRepository<User1> userRepository,
            ContextRepository<Departament1> departamentRepository, ContextRepository<Group1> groupRepository,
            ContextRepository<Lecture1> lectureRepository, ContextRepository<Room1> roomRepository,
            ContextRepository<Subject1> subjectRepository, ContextRepository<Teacher1> teacherRepository)
        {
            _db = db;

            Users = userRepository;
            Departaments = departamentRepository;
            Groups = groupRepository;
            Lectures = lectureRepository;
            Rooms = roomRepository;
            Subjects = subjectRepository;
            Teachers = teacherRepository;
        }

        public ContextRepository<User1> Users { get; }

        public ContextRepository<Departament1> Departaments { get; }

        public ContextRepository<Group1> Groups { get; }

        public ContextRepository<Lecture1> Lectures { get; }

        public ContextRepository<Room1> Rooms { get; }

        public ContextRepository<Subject1> Subjects { get; }

        public ContextRepository<Teacher1> Teachers { get; }


        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed;


        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                _db.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
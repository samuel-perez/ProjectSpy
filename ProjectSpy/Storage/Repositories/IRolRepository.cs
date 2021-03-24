namespace ProjectSpy.Storage.Repositories
{
    using ProjectSpy.Storage.Entities;

    public interface IRolRepository
    {
        public Rol GetById(int id);
    }
}
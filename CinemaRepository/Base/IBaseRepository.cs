using CinemaDomain.Base;

namespace CinemaRepository.Base
{
    public interface IBaseRepository<TypeEntity> where TypeEntity : IBaseEntity
    {
        void Create(TypeEntity entity);
        TypeEntity Read(int id);
        IList<TypeEntity> ReadAll ();
        void Update(TypeEntity entity);
        void Delete(int id);
    }
}

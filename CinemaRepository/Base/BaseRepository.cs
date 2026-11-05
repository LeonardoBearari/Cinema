using CinemaDomain.Base;
using CinemaRepository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Base
{
    public class BaseRepository<TypeEntity> : IBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyDBContext _myDbContext;

        public BaseRepository(MyDBContext myDbContext)
        {
            _myDbContext = myDbContext;
            _myDbContext.Set<TypeEntity>();
        }
        public void Create(TypeEntity entity)
        {
            _myDbContext.Add(entity);
            _myDbContext.SaveChanges();
        }
        public TypeEntity ReadById(int id)
        {
            var dbContext = _myDbContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList().Find(x => x.Id == id);
        }

        public IList<TypeEntity> ReadAll()
        {
            var dbContext = _myDbContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList();
        }

        public void Update(TypeEntity entity)
        {
            var localEntity = _myDbContext.Set<TypeEntity>()
                .Local
                .FirstOrDefault(existingEntity => existingEntity.Id == entity.Id);

            if (localEntity is not null)
            {
                _myDbContext.Entry(localEntity).CurrentValues.SetValues(entity);
                _myDbContext.Entry(localEntity).State = EntityState.Modified;
            }
            else
            {
                _myDbContext.Entry(entity).State = EntityState.Modified;
            }

            _myDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            _myDbContext.Remove(ReadById(id));
            _myDbContext.SaveChanges();
        }
    }
}

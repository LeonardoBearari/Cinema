using AutoMapper;
using CinemaDomain.Base;
using CinemaRepository.Base;
using FluentValidation;
using Microsoft.IdentityModel.Tokens.Experimental;

namespace CinemaService.Base
{
    public class BaseService<TypeEntity> : IBaseService<TypeEntity> where TypeEntity : IBaseEntity
    {
        private readonly IBaseRepository<TypeEntity> _baseRepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TypeEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        private void Validate(TypeEntity obj, AbstractValidator<TypeEntity> validator)
        {
            validator.ValidateAndThrow(obj);
        }

        public TypeOutputModel Create<TypeInputModel, TypeOutputModel, TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>
        {
            var e = _mapper.Map<TypeEntity>(entity);
            Validate(e, Activator.CreateInstance<TypeValidator>());
            _baseRepository.Create(e);
            var outputModel = _mapper.Map<TypeOutputModel>(e);
            return outputModel;
        }

        public TypeOutputModel Read<TypeOutputModel>(int id) where TypeOutputModel : class
        {
            var entity = _baseRepository.Read(id);
            return _mapper.Map<TypeOutputModel>(entity); 
        }

        public IEnumerable<TypeOutputModel> ReadAll<TypeOutputModel>() where TypeOutputModel : class
        {
            var entities = _baseRepository.ReadAll();
            return entities.Select(e => _mapper.Map<TypeOutputModel>(e));
        }

        public TypeOutputModel Update<TypeInputModel, TypeOutputModel, TypeValidator>(TypeEntity entity)
                    where TypeInputModel : class
                    where TypeOutputModel : class
                    where TypeValidator : AbstractValidator<TypeEntity>
        {
            var e = _mapper.Map<TypeEntity>(entity);
            Validate(e, Activator.CreateInstance<TypeValidator>());
            _baseRepository.Update(e);
            return _mapper.Map<TypeOutputModel>(e);
        }


        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }
    }
        
}

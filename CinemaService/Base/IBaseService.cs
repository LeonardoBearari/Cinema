using FluentValidation;
using CinemaDomain.Base;

namespace CinemaService.Base
{
    public interface IBaseService<TypeEntity> where TypeEntity : IBaseEntity
    {
        
        TypeOutputModel Create<TypeInputModel, TypeOutputModel, TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>;

        TypeOutputModel Read<TypeOutputModel>(int id)
            where TypeOutputModel : class;

        IEnumerable<TypeOutputModel> ReadAll<TypeOutputModel>()
            where TypeOutputModel : class;

        TypeOutputModel Update<TypeInputModel, TypeOutputModel, TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>;

        void Delete(int id);




    }
}
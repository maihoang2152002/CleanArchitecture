using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces.Repository
{
    public interface IModelRepository
    {
        Task<ICollection<Model>> GetAll();

        Task<Model> GetModelById(Guid ModelId);

        Task<Model> AddModel(Model Model);

        Task<Model> UpdateModel(Guid Id, string name);

        Task DeleteModel(Guid ModelId);
    }
}

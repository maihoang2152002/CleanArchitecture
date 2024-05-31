using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces.Repository
{
    public interface IInitModelRepository
    {
        Task<ICollection<InitModel>> GetAll();

        Task<InitModel> GetInitModelById(string InitModelId);

        Task<InitModel> AddInitModel(InitModel InitModel);

        Task<InitModel> UpdateInitModel(string Id, string name);

        Task DeleteInitModel(string InitModelId);
    }
}

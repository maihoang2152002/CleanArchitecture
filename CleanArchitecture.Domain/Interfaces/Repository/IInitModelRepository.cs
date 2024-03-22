﻿using CleanArchitecture.Domain.Entities;
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

        Task<InitModel> GetInitModelById(Guid InitModelId);

        Task<InitModel> AddInitModel(InitModel InitModel);

        Task<InitModel> UpdateInitModel(Guid Id, string name);

        Task DeleteInitModel(Guid InitModelId);
    }
}

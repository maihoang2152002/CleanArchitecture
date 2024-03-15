using CleanArchitecture.Domain.CustomException;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repository
{
    public class ModelRepository : IModelRepository
    {
        private readonly CleanArchitectureDbContext _context;
        private readonly ILogger<ModelRepository> _logger;

        public ModelRepository(CleanArchitectureDbContext context, ILogger<ModelRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Model> AddModel(Model Model)
        {
            _context.Model.Add(Model);
            await _context.SaveChangesAsync();
            return Model;
        }

        public async Task DeleteModel(Guid ModelId)
        {
            var Model = _context.Model.FirstOrDefault(p => p.Id == ModelId);
            if (Model == null)
            {
                throw new ModelNotFoundException(ModelId, string.Empty);
            }
            _context.Model.Remove(Model);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Model>> GetAll()
        {
            var Models = await _context.Model.ToListAsync();

            return Models;
        }

        public async Task<Model> GetModelById(Guid ModelId)
        {
            var Model = await _context.Model.FirstOrDefaultAsync(p => p.Id == ModelId);
            return Model;
        }

        public async Task<Model> UpdateModel(Guid id, string name)
        {
            var Model = await _context.Model.FirstOrDefaultAsync(p => p.Id == id);
            if (Model == null)
            {
                throw new ModelNotFoundException(id, name);
            }

            Model.ModelName = name;

            _context.Model.Update(Model);
            await _context.SaveChangesAsync();

            return Model;
        }
    }
}

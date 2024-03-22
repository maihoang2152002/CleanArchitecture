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
    public class InitModelRepository : IInitModelRepository
    {
        private readonly CleanArchitectureDbContext _context;
        private readonly ILogger<InitModelRepository> _logger;

        public InitModelRepository(CleanArchitectureDbContext context, ILogger<InitModelRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<InitModel> AddInitModel(InitModel InitModel)
        {
            _context.InitModel.Add(InitModel);
            await _context.SaveChangesAsync();
            return InitModel;
        }

        public async Task DeleteInitModel(Guid InitModelId)
        {
            var InitModel = _context.InitModel.FirstOrDefault(p => p.Id == InitModelId);
            if (InitModel == null)
            {
                throw new InitModelNotFoundException(InitModelId, string.Empty);
            }
            _context.InitModel.Remove(InitModel);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<InitModel>> GetAll()
        {
            var InitModels = await _context.InitModel.ToListAsync();

            return InitModels;
        }

        public async Task<InitModel> GetInitModelById(Guid InitModelId)
        {
            var InitModel = await _context.InitModel.FirstOrDefaultAsync(p => p.Id == InitModelId);
            return InitModel;
        }

        public async Task<InitModel> UpdateInitModel(Guid id, string name)
        {
            var InitModel = await _context.InitModel.FirstOrDefaultAsync(p => p.Id == id);
            if (InitModel == null)
            {
                throw new InitModelNotFoundException(id, name);
            }

            InitModel.InitModelName = name;

            _context.InitModel.Update(InitModel);
            await _context.SaveChangesAsync();

            return InitModel;
        }
    }
}

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
            _context.InitModels.Add(InitModel);
            await _context.SaveChangesAsync();
            return InitModel;
        }

        public async Task DeleteInitModel(string InitModelId)
        {
            var InitModel = _context.InitModels.FirstOrDefault(p => p.Id == InitModelId);
            if (InitModel == null)
            {
                throw new InitModelNotFoundException(InitModelId, string.Empty);
            }
            _context.InitModels.Remove(InitModel);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<InitModel>> GetAll()
        {
            var InitModels = await _context.InitModels.ToListAsync();

            return InitModels;
        }

        public async Task<InitModel> GetInitModelById(string InitModelId)
        {
            var InitModel = await _context.InitModels.FirstOrDefaultAsync(p => p.Id == InitModelId);
            return InitModel;
        }

        public async Task<InitModel> UpdateInitModel(InitModel InitModel)
        {
            var check = await _context.InitModels.FirstOrDefaultAsync(p => p.Id == InitModel.Id);
            if (check == null)
            {
                throw new InitModelNotFoundException(InitModel.Id, string.Empty);
            }

            //check = InitModel;

            _context.InitModels.Update(check);
            await _context.SaveChangesAsync();

            return InitModel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Model.Commands
{
    public class UpdateModelCommand : IRequest<CleanArchitecture.Domain.Entities.Model>
    {
        public Guid ModelId { get; set; }
        public string ModelName { get; set; }
        public long Price { get; set; }
        public string ModelType { get; set; }
        public Guid? CategoryId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Domain.Entities.Configuration
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(new Model { Id = Guid.NewGuid(), ModelName = "System Design By Paritosh Gupta" },
                            new Model { Id = Guid.NewGuid(), ModelName = "Two States By Chetan Bhagat" },
                            new Model { Id = Guid.NewGuid(), ModelName = "Harry Potter and the Philosopher Stone by J.K. Rowling" },
                            new Model { Id = Guid.NewGuid(), ModelName = "IQOO Z6" },
                            new Model { Id = Guid.NewGuid(), ModelName = "Samsung Galaxy Tab A9+" },
                            new Model { Id = Guid.NewGuid(), ModelName = "Fossil Gen 6 Digital Black Dial Men's Watch-FTW4061" },
                            new Model { Id = Guid.NewGuid(), ModelName = "Fastrack New Limitless FS1 Smart Watch" }
                );
        }
    }
}

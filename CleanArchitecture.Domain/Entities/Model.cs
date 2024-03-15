using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    public class Model
    {
        [Key]
        public Guid Id { get; set; }
        public string ModelName { get; set; }
    }
}
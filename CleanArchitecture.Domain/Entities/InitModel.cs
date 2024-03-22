using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    public class InitModel
    {
        [Key]
        public Guid Id { get; set; }
        public string InitModelName { get; set; }
    }
}
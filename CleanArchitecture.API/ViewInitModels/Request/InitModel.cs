using System;
using System.Runtime.Serialization;

namespace CleanArchitecture.Domain.ViewInitModels.Request
{
    public class InitModel
    {
        public Guid Id { get; set; }
        public string InitModelName { get; set; }
    }
}
using System;
using System.Runtime.Serialization;

namespace CleanArchitecture.Domain.ViewModels.Request
{
    public class Model
    {
        public Guid Id { get; set; }
        public string ModelName { get; set; }
    }
}
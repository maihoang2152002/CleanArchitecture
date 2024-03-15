using System;
using System.Runtime.Serialization;

namespace CleanArchitecture.Domain.ViewModels.Request
{
    public class Model
    {
        public Guid Id { get; set; }
        public string ModelName { get; set; }
        public long Price { get; set; }
        public string ModelType { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
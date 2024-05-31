using System;
using System.Runtime.Serialization;

namespace CleanArchitecture.Domain.ViewInitModels.Request
{
    public class InitModel
    {
        public string Id { get; set; }
        public string InitModelName { get; set; }
    }
}
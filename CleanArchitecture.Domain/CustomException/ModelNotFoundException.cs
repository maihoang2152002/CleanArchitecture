using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.CustomException
{
    // Define a serializable derived exception class.
    [Serializable]
    public class ModelNotFoundException : Exception
    {
        public Guid ModelId { get; set; }
        public string ModelName { get; set; }

        private const string DefaultMessage = "Model does not exist.";
        public ModelNotFoundException() : base(DefaultMessage)
        {

        }
        public ModelNotFoundException(string message) : base(message)
        {

        }

        // This public constructor is used by class instantiators.
        public ModelNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public ModelNotFoundException(Guid ModelId, string ModelName) : this($"Model does not exist with ID: '{ModelId}' and Name: '{ModelName}'.")
        {
            ModelId = ModelId;
            ModelName = ModelName;
        }

        // This protected constructor is used for deserialization.
        protected ModelNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            ModelId = (Guid)info.GetValue(nameof(ModelId), typeof(Guid));
            ModelName = (string)info.GetValue(nameof(ModelName), typeof(string));
        }

        // GetObjectData performs a custom serialization.
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Change the case of two properties, and then use the
            // method of the base class.
            base.GetObjectData(info, context);
            info.AddValue(nameof(ModelId), ModelId, typeof(Guid));
            info.AddValue(nameof(ModelName), ModelName, typeof(string));
        }
    }
}

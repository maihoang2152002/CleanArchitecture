using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.CustomException
{
    // Define a serializable derived exception class.
    [Serializable]
    public class InitModelNotFoundException : Exception
    {
        public Guid InitModelId { get; set; }
        public string InitModelName { get; set; }

        private const string DefaultMessage = "InitModel does not exist.";
        public InitModelNotFoundException() : base(DefaultMessage)
        {

        }
        public InitModelNotFoundException(string message) : base(message)
        {

        }

        // This public constructor is used by class instantiators.
        public InitModelNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public InitModelNotFoundException(Guid InitModelId, string InitModelName) : this($"InitModel does not exist with ID: '{InitModelId}' and Name: '{InitModelName}'.")
        {
            InitModelId = InitModelId;
            InitModelName = InitModelName;
        }

        // This protected constructor is used for deserialization.
        protected InitModelNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            InitModelId = (Guid)info.GetValue(nameof(InitModelId), typeof(Guid));
            InitModelName = (string)info.GetValue(nameof(InitModelName), typeof(string));
        }

        // GetObjectData performs a custom serialization.
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Change the case of two properties, and then use the
            // method of the base class.
            base.GetObjectData(info, context);
            info.AddValue(nameof(InitModelId), InitModelId, typeof(Guid));
            info.AddValue(nameof(InitModelName), InitModelName, typeof(string));
        }
    }
}

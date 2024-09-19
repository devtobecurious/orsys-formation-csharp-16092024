using System.Runtime.Serialization;

namespace SdA.Models.Exceptions
{
    public class DifferentCharacterRequiredException : Exception
    {
        public DifferentCharacterRequiredException(Character character)
        {
            this.Character = character;
        }

        public DifferentCharacterRequiredException(string? message) : base(message)
        {
        }

        public DifferentCharacterRequiredException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DifferentCharacterRequiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #region Properties
        public Character? Character
        {
            get => this.Data["Character"] as Character;
            private set => this.Data["Character"] = value;
        }
        #endregion
    }
}

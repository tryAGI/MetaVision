
#nullable enable

namespace MetaVision
{
    /// <summary>
    /// Generation task state.
    /// </summary>
    public enum GenerationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationStatus value)
        {
            return value switch
            {
                GenerationStatus.Failed => "failed",
                GenerationStatus.Processing => "processing",
                GenerationStatus.Queued => "queued",
                GenerationStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GenerationStatus.Failed,
                "processing" => GenerationStatus.Processing,
                "queued" => GenerationStatus.Queued,
                "success" => GenerationStatus.Success,
                _ => null,
            };
        }
    }
}
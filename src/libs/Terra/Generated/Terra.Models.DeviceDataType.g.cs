
#nullable enable

namespace Terra
{
    /// <summary>
    /// Represents data types that a certain device contributed to.
    /// </summary>
    public enum DeviceDataType
    {
        /// <summary>
        /// 
        /// </summary>
        ActiveMinutes,
        /// <summary>
        /// 
        /// </summary>
        Bmr,
        /// <summary>
        /// 
        /// </summary>
        Cadence,
        /// <summary>
        /// 
        /// </summary>
        Calories,
        /// <summary>
        /// 
        /// </summary>
        Distance,
        /// <summary>
        /// 
        /// </summary>
        HeartRate,
        /// <summary>
        /// 
        /// </summary>
        OxygenSaturation,
        /// <summary>
        /// 
        /// </summary>
        SleepType,
        /// <summary>
        /// 
        /// </summary>
        Speed,
        /// <summary>
        /// 
        /// </summary>
        Steps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeviceDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeviceDataType value)
        {
            return value switch
            {
                DeviceDataType.ActiveMinutes => "ACTIVE_MINUTES",
                DeviceDataType.Bmr => "BMR",
                DeviceDataType.Cadence => "CADENCE",
                DeviceDataType.Calories => "CALORIES",
                DeviceDataType.Distance => "DISTANCE",
                DeviceDataType.HeartRate => "HEART_RATE",
                DeviceDataType.OxygenSaturation => "OXYGEN_SATURATION",
                DeviceDataType.SleepType => "SLEEP_TYPE",
                DeviceDataType.Speed => "SPEED",
                DeviceDataType.Steps => "STEPS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeviceDataType? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_MINUTES" => DeviceDataType.ActiveMinutes,
                "BMR" => DeviceDataType.Bmr,
                "CADENCE" => DeviceDataType.Cadence,
                "CALORIES" => DeviceDataType.Calories,
                "DISTANCE" => DeviceDataType.Distance,
                "HEART_RATE" => DeviceDataType.HeartRate,
                "OXYGEN_SATURATION" => DeviceDataType.OxygenSaturation,
                "SLEEP_TYPE" => DeviceDataType.SleepType,
                "SPEED" => DeviceDataType.Speed,
                "STEPS" => DeviceDataType.Steps,
                _ => null,
            };
        }
    }
}
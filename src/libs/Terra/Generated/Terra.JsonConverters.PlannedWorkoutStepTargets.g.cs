#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class PlannedWorkoutStepTargetsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.PlannedWorkoutStepTargets>
    {
        /// <inheritdoc />
        public override global::Terra.PlannedWorkoutStepTargets Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStepTargetsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStepTargetsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PlannedWorkoutStepTargetsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Terra.PlannedWorkoutStepTarget? plannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.PlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PlannedWorkoutStepTarget)}");
                plannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.CadencePlannedWorkoutStepTarget? cadencePlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.CadencePlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CadencePlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CadencePlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.CadencePlannedWorkoutStepTarget)}");
                cadencePlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.HRPlannedWorkoutStepTarget? hRPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.HRPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HRPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HRPlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.HRPlannedWorkoutStepTarget)}");
                hRPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.PowerPlannedWorkoutStepTarget? powerPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.PowerPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PowerPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PowerPlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PowerPlannedWorkoutStepTarget)}");
                powerPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.SpeedPlannedWorkoutStepTarget? speedPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.SpeedPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SpeedPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SpeedPlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.SpeedPlannedWorkoutStepTarget)}");
                speedPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.PacePlannedWorkoutStepTarget? pacePlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.PacePlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PacePlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PacePlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PacePlannedWorkoutStepTarget)}");
                pacePlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.TSSPlannedWorkoutStepTarget? tSSPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.TSSPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.TSSPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.TSSPlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.TSSPlannedWorkoutStepTarget)}");
                tSSPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.IFPlannedWorkoutStepTarget? iFPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.IFPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.IFPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.IFPlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.IFPlannedWorkoutStepTarget)}");
                iFPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.RepetitionPlannedWorkoutStepTarget? repetitionPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.RepetitionPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RepetitionPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RepetitionPlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.RepetitionPlannedWorkoutStepTarget)}");
                repetitionPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.SwimStrokePlannedWorkoutStepTarget? swimStrokePlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.SwimStrokePlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokePlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokePlannedWorkoutStepTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.SwimStrokePlannedWorkoutStepTarget)}");
                swimStrokePlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Terra.PlannedWorkoutStepTargets(
                discriminator?.Type,
                plannedWorkoutStepTarget,

                cadencePlannedWorkoutStepTarget,

                hRPlannedWorkoutStepTarget,

                powerPlannedWorkoutStepTarget,

                speedPlannedWorkoutStepTarget,

                pacePlannedWorkoutStepTarget,

                tSSPlannedWorkoutStepTarget,

                iFPlannedWorkoutStepTarget,

                repetitionPlannedWorkoutStepTarget,

                swimStrokePlannedWorkoutStepTarget
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.PlannedWorkoutStepTargets value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsCadencePlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CadencePlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CadencePlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CadencePlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CadencePlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsHRPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HRPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HRPlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.HRPlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HRPlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsPowerPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PowerPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PowerPlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PowerPlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PowerPlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsSpeedPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SpeedPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SpeedPlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SpeedPlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeedPlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsPacePlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PacePlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PacePlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PacePlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PacePlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsTSSPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.TSSPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.TSSPlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.TSSPlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TSSPlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsIFPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.IFPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.IFPlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.IFPlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IFPlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsRepetitionPlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RepetitionPlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RepetitionPlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.RepetitionPlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepetitionPlannedWorkoutStepTarget!, typeInfo);
            }
            else if (value.IsSwimStrokePlannedWorkoutStepTarget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokePlannedWorkoutStepTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokePlannedWorkoutStepTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokePlannedWorkoutStepTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokePlannedWorkoutStepTarget!, typeInfo);
            }
        }
    }
}
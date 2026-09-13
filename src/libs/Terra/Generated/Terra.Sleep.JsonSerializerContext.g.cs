
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Problem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TerraUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhookStatus), TypeInfoPropertyName = "DataSentToWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhookUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeviceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Sleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepDataEnrichment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ReadinessData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RespirationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepDurationsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepTemperatureData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RecordFloat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeviceDataType), TypeInfoPropertyName = "DeviceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OtherDeviceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.DeviceDataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.OtherDeviceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateDataSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateVariabilityDataSampleRMSSD))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateVariabilityDataSampleSDNN))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateDataDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HeartRateDataSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleRMSSD>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleSDNN>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateZoneData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateDataSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HeartRateZoneData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OxygenSaturationSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.OxygenSaturationSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BreathSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BreathsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.BreathSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OxygenSaturationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SnoringSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SnoringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.SnoringSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AsleepDurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AwakeDurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepHypnogramSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OtherSleepDurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.SleepHypnogramSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<int?, global::System.DateTime?>), TypeInfoPropertyName = "OneOfInt32DateTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.SleepGetResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfSleepGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhookStatus?), TypeInfoPropertyName = "NullableDataSentToWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeviceDataType?), TypeInfoPropertyName = "NullableDeviceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<int?, global::System.DateTime?>?), TypeInfoPropertyName = "NullableOneOfInt32DateTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.SleepGetResponse2, global::Terra.DataSentToWebhook>?), TypeInfoPropertyName = "NullableOneOfSleepGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.DeviceDataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.OtherDeviceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HeartRateDataSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HeartRateVariabilityDataSampleRMSSD>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HeartRateVariabilityDataSampleSDNN>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HeartRateZoneData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.OxygenSaturationSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.BreathSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.SnoringSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.SleepHypnogramSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Sleep>))]
    internal sealed partial class SleepSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SleepSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SleepSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SleepSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.SleepGetResponse2, global::Terra.DataSentToWebhook>());
            options.Converters.Add(new global::Terra.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Terra.DataSentToWebhookStatus)

                    || typeToConvert == typeof(global::Terra.DataSentToWebhookStatus?)

                    || typeToConvert == typeof(global::Terra.DeviceDataType)

                    || typeToConvert == typeof(global::Terra.DeviceDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Terra.DataSentToWebhookStatus))
                {
                    return new global::Terra.JsonConverters.DataSentToWebhookStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DataSentToWebhookStatus?))
                {
                    return new global::Terra.JsonConverters.DataSentToWebhookStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DeviceDataType))
                {
                    return new global::Terra.JsonConverters.DeviceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DeviceDataType?))
                {
                    return new global::Terra.JsonConverters.DeviceDataTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SleepSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
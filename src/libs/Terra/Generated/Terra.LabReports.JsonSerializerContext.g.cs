
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Problem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ReportType), TypeInfoPropertyName = "ReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportStatusEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportStatusEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportPanel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportPanel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportResultSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportBiomarker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportInterpretation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportReferenceRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportReferenceRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AnatomicalRegion), TypeInfoPropertyName = "AnatomicalRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportBoundedValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportQualitativeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportAppliedRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportRangeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportDeliveriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportDelivery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ReportsUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportsUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ReportsListReportType), TypeInfoPropertyName = "ReportsListReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportsListReportType), TypeInfoPropertyName = "LabReportsListReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ReportType?), TypeInfoPropertyName = "NullableReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AnatomicalRegion?), TypeInfoPropertyName = "NullableAnatomicalRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ReportsListReportType?), TypeInfoPropertyName = "NullableReportsListReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportsListReportType?), TypeInfoPropertyName = "NullableLabReportsListReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportStatusEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportPanel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportReferenceRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportFile>))]
    internal sealed partial class LabReportsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabReportsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LabReportsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LabReportsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Terra.ReportType)

                    || typeToConvert == typeof(global::Terra.ReportType?)

                    || typeToConvert == typeof(global::Terra.AnatomicalRegion)

                    || typeToConvert == typeof(global::Terra.AnatomicalRegion?)

                    || typeToConvert == typeof(global::Terra.ReportsListReportType)

                    || typeToConvert == typeof(global::Terra.ReportsListReportType?)

                    || typeToConvert == typeof(global::Terra.LabReportsListReportType)

                    || typeToConvert == typeof(global::Terra.LabReportsListReportType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Terra.ReportType))
                {
                    return new global::Terra.JsonConverters.ReportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ReportType?))
                {
                    return new global::Terra.JsonConverters.ReportTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AnatomicalRegion))
                {
                    return new global::Terra.JsonConverters.AnatomicalRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AnatomicalRegion?))
                {
                    return new global::Terra.JsonConverters.AnatomicalRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ReportsListReportType))
                {
                    return new global::Terra.JsonConverters.ReportsListReportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ReportsListReportType?))
                {
                    return new global::Terra.JsonConverters.ReportsListReportTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LabReportsListReportType))
                {
                    return new global::Terra.JsonConverters.LabReportsListReportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LabReportsListReportType?))
                {
                    return new global::Terra.JsonConverters.LabReportsListReportTypeNullableJsonConverter();
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
                    0 => new LabReportsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
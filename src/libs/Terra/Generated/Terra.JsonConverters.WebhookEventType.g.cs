#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class WebhookEventTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.WebhookEventType>
    {
        /// <inheritdoc />
        public override global::Terra.WebhookEventType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("creation_timestamp")) __score0++;
            if (__jsonProps.Contains("sent_webhooks_last_hour")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("trend_percentage")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("reference_id")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("user")) __score1++;
            if (__jsonProps.Contains("widget_session_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("message")) __score2++;
            if (__jsonProps.Contains("provider")) __score2++;
            if (__jsonProps.Contains("reason")) __score2++;
            if (__jsonProps.Contains("reference_id")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("user")) __score2++;
            if (__jsonProps.Contains("widget_session_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("message")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("user")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("message")) __score4++;
            if (__jsonProps.Contains("new_user")) __score4++;
            if (__jsonProps.Contains("old_user")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("message")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("user")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("message")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("user")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("message")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("user")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("message")) __score8++;
            if (__jsonProps.Contains("scopes_added")) __score8++;
            if (__jsonProps.Contains("scopes_removed")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("user")) __score8++;
            if (__jsonProps.Contains("version")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("message")) __score9++;
            if (__jsonProps.Contains("retry_after_seconds")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("user")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("message")) __score10++;
            if (__jsonProps.Contains("reference")) __score10++;
            if (__jsonProps.Contains("status")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            if (__jsonProps.Contains("user")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("expected_payloads")) __score11++;
            if (__jsonProps.Contains("message")) __score11++;
            if (__jsonProps.Contains("reference")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("user")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("end_date")) __score12++;
            if (__jsonProps.Contains("message")) __score12++;
            if (__jsonProps.Contains("retrying_at")) __score12++;
            if (__jsonProps.Contains("start_date")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            if (__jsonProps.Contains("user")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("data")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            if (__jsonProps.Contains("user")) __score13++;
            if (__jsonProps.Contains("version")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("athlete")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            if (__jsonProps.Contains("user")) __score14++;
            if (__jsonProps.Contains("version")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("data")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            if (__jsonProps.Contains("user")) __score15++;
            if (__jsonProps.Contains("version")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("data")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            if (__jsonProps.Contains("user")) __score16++;
            if (__jsonProps.Contains("version")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("data")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            if (__jsonProps.Contains("user")) __score17++;
            if (__jsonProps.Contains("version")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("data")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            if (__jsonProps.Contains("user")) __score18++;
            if (__jsonProps.Contains("version")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("data")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            if (__jsonProps.Contains("user")) __score19++;
            if (__jsonProps.Contains("version")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("expires_in")) __score20++;
            if (__jsonProps.Contains("status")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            if (__jsonProps.Contains("url")) __score20++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }

            global::Terra.HealthcheckEvent? healthcheck = default;
            global::Terra.AuthSuccessEvent? authSuccess = default;
            global::Terra.AuthErrorEvent? authError = default;
            global::Terra.DeauthEvent? deauth = default;
            global::Terra.UserReauthEvent? userReauth = default;
            global::Terra.AccessRevokedEvent? accessRevoked = default;
            global::Terra.ConnectionErrorEvent? connectionError = default;
            global::Terra.GoogleNoDatasourceEvent? googleNoDatasource = default;
            global::Terra.PermissionChangeEvent? permissionChange = default;
            global::Terra.ProcessingEvent? processing = default;
            global::Terra.LargeRequestProcessingEvent? largeRequestProcessing = default;
            global::Terra.LargeRequestSendingEvent? largeRequestSending = default;
            global::Terra.RateLimitHitEvent? rateLimitHit = default;
            global::Terra.ActivityEvent? activity = default;
            global::Terra.AthleteEvent? athlete = default;
            global::Terra.BodyEvent? body = default;
            global::Terra.DailyEvent? daily = default;
            global::Terra.MenstruationEvent? menstruation = default;
            global::Terra.NutritionEvent? nutrition = default;
            global::Terra.SleepEvent? sleep = default;
            global::Terra.S3PayloadEvent? s3Payload = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HealthcheckEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HealthcheckEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.HealthcheckEvent).Name}");
                        healthcheck = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AuthSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AuthSuccessEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AuthSuccessEvent).Name}");
                        authSuccess = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AuthErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AuthErrorEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AuthErrorEvent).Name}");
                        authError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.DeauthEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.DeauthEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.DeauthEvent).Name}");
                        deauth = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.UserReauthEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.UserReauthEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.UserReauthEvent).Name}");
                        userReauth = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AccessRevokedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AccessRevokedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AccessRevokedEvent).Name}");
                        accessRevoked = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ConnectionErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ConnectionErrorEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ConnectionErrorEvent).Name}");
                        connectionError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.GoogleNoDatasourceEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.GoogleNoDatasourceEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.GoogleNoDatasourceEvent).Name}");
                        googleNoDatasource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PermissionChangeEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PermissionChangeEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PermissionChangeEvent).Name}");
                        permissionChange = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ProcessingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ProcessingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ProcessingEvent).Name}");
                        processing = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.LargeRequestProcessingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.LargeRequestProcessingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.LargeRequestProcessingEvent).Name}");
                        largeRequestProcessing = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.LargeRequestSendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.LargeRequestSendingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.LargeRequestSendingEvent).Name}");
                        largeRequestSending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RateLimitHitEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RateLimitHitEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.RateLimitHitEvent).Name}");
                        rateLimitHit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ActivityEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ActivityEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ActivityEvent).Name}");
                        activity = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AthleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AthleteEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AthleteEvent).Name}");
                        athlete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.BodyEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.BodyEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.BodyEvent).Name}");
                        body = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.DailyEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.DailyEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.DailyEvent).Name}");
                        daily = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.MenstruationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.MenstruationEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.MenstruationEvent).Name}");
                        menstruation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.NutritionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.NutritionEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.NutritionEvent).Name}");
                        nutrition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SleepEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SleepEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SleepEvent).Name}");
                        sleep = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.S3PayloadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.S3PayloadEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.S3PayloadEvent).Name}");
                        s3Payload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (healthcheck == null && authSuccess == null && authError == null && deauth == null && userReauth == null && accessRevoked == null && connectionError == null && googleNoDatasource == null && permissionChange == null && processing == null && largeRequestProcessing == null && largeRequestSending == null && rateLimitHit == null && activity == null && athlete == null && body == null && daily == null && menstruation == null && nutrition == null && sleep == null && s3Payload == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HealthcheckEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HealthcheckEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.HealthcheckEvent).Name}");
                    healthcheck = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AuthSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AuthSuccessEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AuthSuccessEvent).Name}");
                    authSuccess = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AuthErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AuthErrorEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AuthErrorEvent).Name}");
                    authError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.DeauthEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.DeauthEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.DeauthEvent).Name}");
                    deauth = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.UserReauthEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.UserReauthEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.UserReauthEvent).Name}");
                    userReauth = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AccessRevokedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AccessRevokedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AccessRevokedEvent).Name}");
                    accessRevoked = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ConnectionErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ConnectionErrorEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ConnectionErrorEvent).Name}");
                    connectionError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.GoogleNoDatasourceEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.GoogleNoDatasourceEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.GoogleNoDatasourceEvent).Name}");
                    googleNoDatasource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PermissionChangeEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PermissionChangeEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PermissionChangeEvent).Name}");
                    permissionChange = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ProcessingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ProcessingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ProcessingEvent).Name}");
                    processing = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.LargeRequestProcessingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.LargeRequestProcessingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.LargeRequestProcessingEvent).Name}");
                    largeRequestProcessing = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.LargeRequestSendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.LargeRequestSendingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.LargeRequestSendingEvent).Name}");
                    largeRequestSending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RateLimitHitEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RateLimitHitEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.RateLimitHitEvent).Name}");
                    rateLimitHit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ActivityEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ActivityEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ActivityEvent).Name}");
                    activity = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AthleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AthleteEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AthleteEvent).Name}");
                    athlete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.BodyEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.BodyEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.BodyEvent).Name}");
                    body = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.DailyEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.DailyEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.DailyEvent).Name}");
                    daily = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.MenstruationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.MenstruationEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.MenstruationEvent).Name}");
                    menstruation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.NutritionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.NutritionEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.NutritionEvent).Name}");
                    nutrition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SleepEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SleepEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SleepEvent).Name}");
                    sleep = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.S3PayloadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.S3PayloadEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.S3PayloadEvent).Name}");
                    s3Payload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.WebhookEventType(
                healthcheck,

                authSuccess,

                authError,

                deauth,

                userReauth,

                accessRevoked,

                connectionError,

                googleNoDatasource,

                permissionChange,

                processing,

                largeRequestProcessing,

                largeRequestSending,

                rateLimitHit,

                activity,

                athlete,

                body,

                daily,

                menstruation,

                nutrition,

                sleep,

                s3Payload
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.WebhookEventType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHealthcheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HealthcheckEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HealthcheckEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.HealthcheckEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Healthcheck!, typeInfo);
            }
            else if (value.IsAuthSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AuthSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AuthSuccessEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AuthSuccessEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthSuccess!, typeInfo);
            }
            else if (value.IsAuthError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AuthErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AuthErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AuthErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthError!, typeInfo);
            }
            else if (value.IsDeauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.DeauthEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.DeauthEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.DeauthEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deauth!, typeInfo);
            }
            else if (value.IsUserReauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.UserReauthEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.UserReauthEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.UserReauthEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserReauth!, typeInfo);
            }
            else if (value.IsAccessRevoked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AccessRevokedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AccessRevokedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AccessRevokedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AccessRevoked!, typeInfo);
            }
            else if (value.IsConnectionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ConnectionErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ConnectionErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ConnectionErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConnectionError!, typeInfo);
            }
            else if (value.IsGoogleNoDatasource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.GoogleNoDatasourceEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.GoogleNoDatasourceEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.GoogleNoDatasourceEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleNoDatasource!, typeInfo);
            }
            else if (value.IsPermissionChange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PermissionChangeEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PermissionChangeEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PermissionChangeEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionChange!, typeInfo);
            }
            else if (value.IsProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ProcessingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ProcessingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ProcessingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Processing!, typeInfo);
            }
            else if (value.IsLargeRequestProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.LargeRequestProcessingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.LargeRequestProcessingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.LargeRequestProcessingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LargeRequestProcessing!, typeInfo);
            }
            else if (value.IsLargeRequestSending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.LargeRequestSendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.LargeRequestSendingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.LargeRequestSendingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LargeRequestSending!, typeInfo);
            }
            else if (value.IsRateLimitHit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RateLimitHitEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RateLimitHitEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.RateLimitHitEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitHit!, typeInfo);
            }
            else if (value.IsActivity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.ActivityEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.ActivityEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.ActivityEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Activity!, typeInfo);
            }
            else if (value.IsAthlete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.AthleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.AthleteEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.AthleteEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Athlete!, typeInfo);
            }
            else if (value.IsBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.BodyEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.BodyEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.BodyEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Body!, typeInfo);
            }
            else if (value.IsDaily)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.DailyEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.DailyEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.DailyEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Daily!, typeInfo);
            }
            else if (value.IsMenstruation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.MenstruationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.MenstruationEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.MenstruationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Menstruation!, typeInfo);
            }
            else if (value.IsNutrition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.NutritionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.NutritionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.NutritionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Nutrition!, typeInfo);
            }
            else if (value.IsSleep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SleepEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SleepEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SleepEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleep!, typeInfo);
            }
            else if (value.IsS3Payload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.S3PayloadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.S3PayloadEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.S3PayloadEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3Payload!, typeInfo);
            }
        }
    }
}
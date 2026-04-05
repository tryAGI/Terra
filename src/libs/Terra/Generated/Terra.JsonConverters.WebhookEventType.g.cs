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
                        healthcheck = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.HealthcheckEvent>(__rawJson, options);
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
                        authSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.AuthSuccessEvent>(__rawJson, options);
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
                        authError = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.AuthErrorEvent>(__rawJson, options);
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
                        deauth = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.DeauthEvent>(__rawJson, options);
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
                        userReauth = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.UserReauthEvent>(__rawJson, options);
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
                        accessRevoked = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.AccessRevokedEvent>(__rawJson, options);
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
                        connectionError = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.ConnectionErrorEvent>(__rawJson, options);
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
                        googleNoDatasource = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.GoogleNoDatasourceEvent>(__rawJson, options);
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
                        permissionChange = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PermissionChangeEvent>(__rawJson, options);
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
                        processing = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.ProcessingEvent>(__rawJson, options);
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
                        largeRequestProcessing = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.LargeRequestProcessingEvent>(__rawJson, options);
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
                        largeRequestSending = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.LargeRequestSendingEvent>(__rawJson, options);
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
                        rateLimitHit = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.RateLimitHitEvent>(__rawJson, options);
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
                        activity = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.ActivityEvent>(__rawJson, options);
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
                        athlete = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.AthleteEvent>(__rawJson, options);
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
                        body = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.BodyEvent>(__rawJson, options);
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
                        daily = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.DailyEvent>(__rawJson, options);
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
                        menstruation = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.MenstruationEvent>(__rawJson, options);
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
                        nutrition = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.NutritionEvent>(__rawJson, options);
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
                        sleep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.SleepEvent>(__rawJson, options);
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
                        s3Payload = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.S3PayloadEvent>(__rawJson, options);
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
                    healthcheck = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.HealthcheckEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    authSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.AuthSuccessEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    authError = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.AuthErrorEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    deauth = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.DeauthEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    userReauth = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.UserReauthEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    accessRevoked = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.AccessRevokedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    connectionError = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.ConnectionErrorEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    googleNoDatasource = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.GoogleNoDatasourceEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    permissionChange = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PermissionChangeEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    processing = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.ProcessingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    largeRequestProcessing = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.LargeRequestProcessingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    largeRequestSending = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.LargeRequestSendingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    rateLimitHit = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.RateLimitHitEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    activity = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.ActivityEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    athlete = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.AthleteEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    body = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.BodyEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    daily = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.DailyEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    menstruation = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.MenstruationEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    nutrition = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.NutritionEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sleep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.SleepEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    s3Payload = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.S3PayloadEvent>(__rawJson, options);
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

            if (value.IsHealthcheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Healthcheck, typeof(global::Terra.HealthcheckEvent), options);
            }
            else if (value.IsAuthSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthSuccess, typeof(global::Terra.AuthSuccessEvent), options);
            }
            else if (value.IsAuthError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthError, typeof(global::Terra.AuthErrorEvent), options);
            }
            else if (value.IsDeauth)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deauth, typeof(global::Terra.DeauthEvent), options);
            }
            else if (value.IsUserReauth)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserReauth, typeof(global::Terra.UserReauthEvent), options);
            }
            else if (value.IsAccessRevoked)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AccessRevoked, typeof(global::Terra.AccessRevokedEvent), options);
            }
            else if (value.IsConnectionError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConnectionError, typeof(global::Terra.ConnectionErrorEvent), options);
            }
            else if (value.IsGoogleNoDatasource)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleNoDatasource, typeof(global::Terra.GoogleNoDatasourceEvent), options);
            }
            else if (value.IsPermissionChange)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionChange, typeof(global::Terra.PermissionChangeEvent), options);
            }
            else if (value.IsProcessing)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Processing, typeof(global::Terra.ProcessingEvent), options);
            }
            else if (value.IsLargeRequestProcessing)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LargeRequestProcessing, typeof(global::Terra.LargeRequestProcessingEvent), options);
            }
            else if (value.IsLargeRequestSending)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LargeRequestSending, typeof(global::Terra.LargeRequestSendingEvent), options);
            }
            else if (value.IsRateLimitHit)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitHit, typeof(global::Terra.RateLimitHitEvent), options);
            }
            else if (value.IsActivity)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Activity, typeof(global::Terra.ActivityEvent), options);
            }
            else if (value.IsAthlete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Athlete, typeof(global::Terra.AthleteEvent), options);
            }
            else if (value.IsBody)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Body, typeof(global::Terra.BodyEvent), options);
            }
            else if (value.IsDaily)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Daily, typeof(global::Terra.DailyEvent), options);
            }
            else if (value.IsMenstruation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Menstruation, typeof(global::Terra.MenstruationEvent), options);
            }
            else if (value.IsNutrition)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Nutrition, typeof(global::Terra.NutritionEvent), options);
            }
            else if (value.IsSleep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleep, typeof(global::Terra.SleepEvent), options);
            }
            else if (value.IsS3Payload)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3Payload, typeof(global::Terra.S3PayloadEvent), options);
            }
        }
    }
}
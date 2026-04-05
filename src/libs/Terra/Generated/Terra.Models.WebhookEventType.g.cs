#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Union of all possible webhook event types
    /// </summary>
    public readonly partial struct WebhookEventType : global::System.IEquatable<WebhookEventType>
    {
        /// <summary>
        /// Healthcheck event sent periodically to verify your webhook endpoint is functional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.HealthcheckEvent? Healthcheck { get; init; }
#else
        public global::Terra.HealthcheckEvent? Healthcheck { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Healthcheck))]
#endif
        public bool IsHealthcheck => Healthcheck != null;

        /// <summary>
        /// Authentication success event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.AuthSuccessEvent? AuthSuccess { get; init; }
#else
        public global::Terra.AuthSuccessEvent? AuthSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthSuccess))]
#endif
        public bool IsAuthSuccess => AuthSuccess != null;

        /// <summary>
        /// Authentication error event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.AuthErrorEvent? AuthError { get; init; }
#else
        public global::Terra.AuthErrorEvent? AuthError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthError))]
#endif
        public bool IsAuthError => AuthError != null;

        /// <summary>
        /// User deauthentication event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.DeauthEvent? Deauth { get; init; }
#else
        public global::Terra.DeauthEvent? Deauth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deauth))]
#endif
        public bool IsDeauth => Deauth != null;

        /// <summary>
        /// User re-authentication event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.UserReauthEvent? UserReauth { get; init; }
#else
        public global::Terra.UserReauthEvent? UserReauth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserReauth))]
#endif
        public bool IsUserReauth => UserReauth != null;

        /// <summary>
        /// Access revoked event when a user revokes access through the provider
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.AccessRevokedEvent? AccessRevoked { get; init; }
#else
        public global::Terra.AccessRevokedEvent? AccessRevoked { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccessRevoked))]
#endif
        public bool IsAccessRevoked => AccessRevoked != null;

        /// <summary>
        /// Connection error event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.ConnectionErrorEvent? ConnectionError { get; init; }
#else
        public global::Terra.ConnectionErrorEvent? ConnectionError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConnectionError))]
#endif
        public bool IsConnectionError => ConnectionError != null;

        /// <summary>
        /// Google no datasource event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.GoogleNoDatasourceEvent? GoogleNoDatasource { get; init; }
#else
        public global::Terra.GoogleNoDatasourceEvent? GoogleNoDatasource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleNoDatasource))]
#endif
        public bool IsGoogleNoDatasource => GoogleNoDatasource != null;

        /// <summary>
        /// Permission change event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PermissionChangeEvent? PermissionChange { get; init; }
#else
        public global::Terra.PermissionChangeEvent? PermissionChange { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PermissionChange))]
#endif
        public bool IsPermissionChange => PermissionChange != null;

        /// <summary>
        /// Processing event returned when data is being fetched asynchronously
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.ProcessingEvent? Processing { get; init; }
#else
        public global::Terra.ProcessingEvent? Processing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Processing))]
#endif
        public bool IsProcessing => Processing != null;

        /// <summary>
        /// Large request processing event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.LargeRequestProcessingEvent? LargeRequestProcessing { get; init; }
#else
        public global::Terra.LargeRequestProcessingEvent? LargeRequestProcessing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LargeRequestProcessing))]
#endif
        public bool IsLargeRequestProcessing => LargeRequestProcessing != null;

        /// <summary>
        /// Large request sending event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.LargeRequestSendingEvent? LargeRequestSending { get; init; }
#else
        public global::Terra.LargeRequestSendingEvent? LargeRequestSending { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LargeRequestSending))]
#endif
        public bool IsLargeRequestSending => LargeRequestSending != null;

        /// <summary>
        /// Rate limit hit event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.RateLimitHitEvent? RateLimitHit { get; init; }
#else
        public global::Terra.RateLimitHitEvent? RateLimitHit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitHit))]
#endif
        public bool IsRateLimitHit => RateLimitHit != null;

        /// <summary>
        /// Activity data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.ActivityEvent? Activity { get; init; }
#else
        public global::Terra.ActivityEvent? Activity { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Activity))]
#endif
        public bool IsActivity => Activity != null;

        /// <summary>
        /// Athlete data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.AthleteEvent? Athlete { get; init; }
#else
        public global::Terra.AthleteEvent? Athlete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Athlete))]
#endif
        public bool IsAthlete => Athlete != null;

        /// <summary>
        /// Body data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.BodyEvent? Body { get; init; }
#else
        public global::Terra.BodyEvent? Body { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Body))]
#endif
        public bool IsBody => Body != null;

        /// <summary>
        /// Daily data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.DailyEvent? Daily { get; init; }
#else
        public global::Terra.DailyEvent? Daily { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Daily))]
#endif
        public bool IsDaily => Daily != null;

        /// <summary>
        /// Menstruation data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.MenstruationEvent? Menstruation { get; init; }
#else
        public global::Terra.MenstruationEvent? Menstruation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Menstruation))]
#endif
        public bool IsMenstruation => Menstruation != null;

        /// <summary>
        /// Nutrition data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.NutritionEvent? Nutrition { get; init; }
#else
        public global::Terra.NutritionEvent? Nutrition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Nutrition))]
#endif
        public bool IsNutrition => Nutrition != null;

        /// <summary>
        /// Sleep data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SleepEvent? Sleep { get; init; }
#else
        public global::Terra.SleepEvent? Sleep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sleep))]
#endif
        public bool IsSleep => Sleep != null;

        /// <summary>
        /// S3 Upload event with data download URL
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.S3PayloadEvent? S3Payload { get; init; }
#else
        public global::Terra.S3PayloadEvent? S3Payload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3Payload))]
#endif
        public bool IsS3Payload => S3Payload != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.HealthcheckEvent value) => new WebhookEventType((global::Terra.HealthcheckEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.HealthcheckEvent?(WebhookEventType @this) => @this.Healthcheck;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.HealthcheckEvent? value)
        {
            Healthcheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.AuthSuccessEvent value) => new WebhookEventType((global::Terra.AuthSuccessEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.AuthSuccessEvent?(WebhookEventType @this) => @this.AuthSuccess;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.AuthSuccessEvent? value)
        {
            AuthSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.AuthErrorEvent value) => new WebhookEventType((global::Terra.AuthErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.AuthErrorEvent?(WebhookEventType @this) => @this.AuthError;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.AuthErrorEvent? value)
        {
            AuthError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.DeauthEvent value) => new WebhookEventType((global::Terra.DeauthEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.DeauthEvent?(WebhookEventType @this) => @this.Deauth;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.DeauthEvent? value)
        {
            Deauth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.UserReauthEvent value) => new WebhookEventType((global::Terra.UserReauthEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.UserReauthEvent?(WebhookEventType @this) => @this.UserReauth;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.UserReauthEvent? value)
        {
            UserReauth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.AccessRevokedEvent value) => new WebhookEventType((global::Terra.AccessRevokedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.AccessRevokedEvent?(WebhookEventType @this) => @this.AccessRevoked;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.AccessRevokedEvent? value)
        {
            AccessRevoked = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.ConnectionErrorEvent value) => new WebhookEventType((global::Terra.ConnectionErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.ConnectionErrorEvent?(WebhookEventType @this) => @this.ConnectionError;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.ConnectionErrorEvent? value)
        {
            ConnectionError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.GoogleNoDatasourceEvent value) => new WebhookEventType((global::Terra.GoogleNoDatasourceEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.GoogleNoDatasourceEvent?(WebhookEventType @this) => @this.GoogleNoDatasource;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.GoogleNoDatasourceEvent? value)
        {
            GoogleNoDatasource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.PermissionChangeEvent value) => new WebhookEventType((global::Terra.PermissionChangeEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PermissionChangeEvent?(WebhookEventType @this) => @this.PermissionChange;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.PermissionChangeEvent? value)
        {
            PermissionChange = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.ProcessingEvent value) => new WebhookEventType((global::Terra.ProcessingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.ProcessingEvent?(WebhookEventType @this) => @this.Processing;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.ProcessingEvent? value)
        {
            Processing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.LargeRequestProcessingEvent value) => new WebhookEventType((global::Terra.LargeRequestProcessingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.LargeRequestProcessingEvent?(WebhookEventType @this) => @this.LargeRequestProcessing;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.LargeRequestProcessingEvent? value)
        {
            LargeRequestProcessing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.LargeRequestSendingEvent value) => new WebhookEventType((global::Terra.LargeRequestSendingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.LargeRequestSendingEvent?(WebhookEventType @this) => @this.LargeRequestSending;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.LargeRequestSendingEvent? value)
        {
            LargeRequestSending = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.RateLimitHitEvent value) => new WebhookEventType((global::Terra.RateLimitHitEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.RateLimitHitEvent?(WebhookEventType @this) => @this.RateLimitHit;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.RateLimitHitEvent? value)
        {
            RateLimitHit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.ActivityEvent value) => new WebhookEventType((global::Terra.ActivityEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.ActivityEvent?(WebhookEventType @this) => @this.Activity;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.ActivityEvent? value)
        {
            Activity = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.AthleteEvent value) => new WebhookEventType((global::Terra.AthleteEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.AthleteEvent?(WebhookEventType @this) => @this.Athlete;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.AthleteEvent? value)
        {
            Athlete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.BodyEvent value) => new WebhookEventType((global::Terra.BodyEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.BodyEvent?(WebhookEventType @this) => @this.Body;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.BodyEvent? value)
        {
            Body = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.DailyEvent value) => new WebhookEventType((global::Terra.DailyEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.DailyEvent?(WebhookEventType @this) => @this.Daily;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.DailyEvent? value)
        {
            Daily = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.MenstruationEvent value) => new WebhookEventType((global::Terra.MenstruationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.MenstruationEvent?(WebhookEventType @this) => @this.Menstruation;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.MenstruationEvent? value)
        {
            Menstruation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.NutritionEvent value) => new WebhookEventType((global::Terra.NutritionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.NutritionEvent?(WebhookEventType @this) => @this.Nutrition;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.NutritionEvent? value)
        {
            Nutrition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.SleepEvent value) => new WebhookEventType((global::Terra.SleepEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SleepEvent?(WebhookEventType @this) => @this.Sleep;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.SleepEvent? value)
        {
            Sleep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.S3PayloadEvent value) => new WebhookEventType((global::Terra.S3PayloadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.S3PayloadEvent?(WebhookEventType @this) => @this.S3Payload;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.S3PayloadEvent? value)
        {
            S3Payload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(
            global::Terra.HealthcheckEvent? healthcheck,
            global::Terra.AuthSuccessEvent? authSuccess,
            global::Terra.AuthErrorEvent? authError,
            global::Terra.DeauthEvent? deauth,
            global::Terra.UserReauthEvent? userReauth,
            global::Terra.AccessRevokedEvent? accessRevoked,
            global::Terra.ConnectionErrorEvent? connectionError,
            global::Terra.GoogleNoDatasourceEvent? googleNoDatasource,
            global::Terra.PermissionChangeEvent? permissionChange,
            global::Terra.ProcessingEvent? processing,
            global::Terra.LargeRequestProcessingEvent? largeRequestProcessing,
            global::Terra.LargeRequestSendingEvent? largeRequestSending,
            global::Terra.RateLimitHitEvent? rateLimitHit,
            global::Terra.ActivityEvent? activity,
            global::Terra.AthleteEvent? athlete,
            global::Terra.BodyEvent? body,
            global::Terra.DailyEvent? daily,
            global::Terra.MenstruationEvent? menstruation,
            global::Terra.NutritionEvent? nutrition,
            global::Terra.SleepEvent? sleep,
            global::Terra.S3PayloadEvent? s3Payload
            )
        {
            Healthcheck = healthcheck;
            AuthSuccess = authSuccess;
            AuthError = authError;
            Deauth = deauth;
            UserReauth = userReauth;
            AccessRevoked = accessRevoked;
            ConnectionError = connectionError;
            GoogleNoDatasource = googleNoDatasource;
            PermissionChange = permissionChange;
            Processing = processing;
            LargeRequestProcessing = largeRequestProcessing;
            LargeRequestSending = largeRequestSending;
            RateLimitHit = rateLimitHit;
            Activity = activity;
            Athlete = athlete;
            Body = body;
            Daily = daily;
            Menstruation = menstruation;
            Nutrition = nutrition;
            Sleep = sleep;
            S3Payload = s3Payload;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            S3Payload as object ??
            Sleep as object ??
            Nutrition as object ??
            Menstruation as object ??
            Daily as object ??
            Body as object ??
            Athlete as object ??
            Activity as object ??
            RateLimitHit as object ??
            LargeRequestSending as object ??
            LargeRequestProcessing as object ??
            Processing as object ??
            PermissionChange as object ??
            GoogleNoDatasource as object ??
            ConnectionError as object ??
            AccessRevoked as object ??
            UserReauth as object ??
            Deauth as object ??
            AuthError as object ??
            AuthSuccess as object ??
            Healthcheck as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Healthcheck?.ToString() ??
            AuthSuccess?.ToString() ??
            AuthError?.ToString() ??
            Deauth?.ToString() ??
            UserReauth?.ToString() ??
            AccessRevoked?.ToString() ??
            ConnectionError?.ToString() ??
            GoogleNoDatasource?.ToString() ??
            PermissionChange?.ToString() ??
            Processing?.ToString() ??
            LargeRequestProcessing?.ToString() ??
            LargeRequestSending?.ToString() ??
            RateLimitHit?.ToString() ??
            Activity?.ToString() ??
            Athlete?.ToString() ??
            Body?.ToString() ??
            Daily?.ToString() ??
            Menstruation?.ToString() ??
            Nutrition?.ToString() ??
            Sleep?.ToString() ??
            S3Payload?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && IsMenstruation && !IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && IsNutrition && !IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && IsSleep && !IsS3Payload || !IsHealthcheck && !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsGoogleNoDatasource && !IsPermissionChange && !IsProcessing && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsRateLimitHit && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && IsS3Payload;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.HealthcheckEvent?, TResult>? healthcheck = null,
            global::System.Func<global::Terra.AuthSuccessEvent?, TResult>? authSuccess = null,
            global::System.Func<global::Terra.AuthErrorEvent?, TResult>? authError = null,
            global::System.Func<global::Terra.DeauthEvent?, TResult>? deauth = null,
            global::System.Func<global::Terra.UserReauthEvent?, TResult>? userReauth = null,
            global::System.Func<global::Terra.AccessRevokedEvent?, TResult>? accessRevoked = null,
            global::System.Func<global::Terra.ConnectionErrorEvent?, TResult>? connectionError = null,
            global::System.Func<global::Terra.GoogleNoDatasourceEvent?, TResult>? googleNoDatasource = null,
            global::System.Func<global::Terra.PermissionChangeEvent?, TResult>? permissionChange = null,
            global::System.Func<global::Terra.ProcessingEvent?, TResult>? processing = null,
            global::System.Func<global::Terra.LargeRequestProcessingEvent?, TResult>? largeRequestProcessing = null,
            global::System.Func<global::Terra.LargeRequestSendingEvent?, TResult>? largeRequestSending = null,
            global::System.Func<global::Terra.RateLimitHitEvent?, TResult>? rateLimitHit = null,
            global::System.Func<global::Terra.ActivityEvent?, TResult>? activity = null,
            global::System.Func<global::Terra.AthleteEvent?, TResult>? athlete = null,
            global::System.Func<global::Terra.BodyEvent?, TResult>? body = null,
            global::System.Func<global::Terra.DailyEvent?, TResult>? daily = null,
            global::System.Func<global::Terra.MenstruationEvent?, TResult>? menstruation = null,
            global::System.Func<global::Terra.NutritionEvent?, TResult>? nutrition = null,
            global::System.Func<global::Terra.SleepEvent?, TResult>? sleep = null,
            global::System.Func<global::Terra.S3PayloadEvent?, TResult>? s3Payload = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHealthcheck && healthcheck != null)
            {
                return healthcheck(Healthcheck!);
            }
            else if (IsAuthSuccess && authSuccess != null)
            {
                return authSuccess(AuthSuccess!);
            }
            else if (IsAuthError && authError != null)
            {
                return authError(AuthError!);
            }
            else if (IsDeauth && deauth != null)
            {
                return deauth(Deauth!);
            }
            else if (IsUserReauth && userReauth != null)
            {
                return userReauth(UserReauth!);
            }
            else if (IsAccessRevoked && accessRevoked != null)
            {
                return accessRevoked(AccessRevoked!);
            }
            else if (IsConnectionError && connectionError != null)
            {
                return connectionError(ConnectionError!);
            }
            else if (IsGoogleNoDatasource && googleNoDatasource != null)
            {
                return googleNoDatasource(GoogleNoDatasource!);
            }
            else if (IsPermissionChange && permissionChange != null)
            {
                return permissionChange(PermissionChange!);
            }
            else if (IsProcessing && processing != null)
            {
                return processing(Processing!);
            }
            else if (IsLargeRequestProcessing && largeRequestProcessing != null)
            {
                return largeRequestProcessing(LargeRequestProcessing!);
            }
            else if (IsLargeRequestSending && largeRequestSending != null)
            {
                return largeRequestSending(LargeRequestSending!);
            }
            else if (IsRateLimitHit && rateLimitHit != null)
            {
                return rateLimitHit(RateLimitHit!);
            }
            else if (IsActivity && activity != null)
            {
                return activity(Activity!);
            }
            else if (IsAthlete && athlete != null)
            {
                return athlete(Athlete!);
            }
            else if (IsBody && body != null)
            {
                return body(Body!);
            }
            else if (IsDaily && daily != null)
            {
                return daily(Daily!);
            }
            else if (IsMenstruation && menstruation != null)
            {
                return menstruation(Menstruation!);
            }
            else if (IsNutrition && nutrition != null)
            {
                return nutrition(Nutrition!);
            }
            else if (IsSleep && sleep != null)
            {
                return sleep(Sleep!);
            }
            else if (IsS3Payload && s3Payload != null)
            {
                return s3Payload(S3Payload!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.HealthcheckEvent?>? healthcheck = null,
            global::System.Action<global::Terra.AuthSuccessEvent?>? authSuccess = null,
            global::System.Action<global::Terra.AuthErrorEvent?>? authError = null,
            global::System.Action<global::Terra.DeauthEvent?>? deauth = null,
            global::System.Action<global::Terra.UserReauthEvent?>? userReauth = null,
            global::System.Action<global::Terra.AccessRevokedEvent?>? accessRevoked = null,
            global::System.Action<global::Terra.ConnectionErrorEvent?>? connectionError = null,
            global::System.Action<global::Terra.GoogleNoDatasourceEvent?>? googleNoDatasource = null,
            global::System.Action<global::Terra.PermissionChangeEvent?>? permissionChange = null,
            global::System.Action<global::Terra.ProcessingEvent?>? processing = null,
            global::System.Action<global::Terra.LargeRequestProcessingEvent?>? largeRequestProcessing = null,
            global::System.Action<global::Terra.LargeRequestSendingEvent?>? largeRequestSending = null,
            global::System.Action<global::Terra.RateLimitHitEvent?>? rateLimitHit = null,
            global::System.Action<global::Terra.ActivityEvent?>? activity = null,
            global::System.Action<global::Terra.AthleteEvent?>? athlete = null,
            global::System.Action<global::Terra.BodyEvent?>? body = null,
            global::System.Action<global::Terra.DailyEvent?>? daily = null,
            global::System.Action<global::Terra.MenstruationEvent?>? menstruation = null,
            global::System.Action<global::Terra.NutritionEvent?>? nutrition = null,
            global::System.Action<global::Terra.SleepEvent?>? sleep = null,
            global::System.Action<global::Terra.S3PayloadEvent?>? s3Payload = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHealthcheck)
            {
                healthcheck?.Invoke(Healthcheck!);
            }
            else if (IsAuthSuccess)
            {
                authSuccess?.Invoke(AuthSuccess!);
            }
            else if (IsAuthError)
            {
                authError?.Invoke(AuthError!);
            }
            else if (IsDeauth)
            {
                deauth?.Invoke(Deauth!);
            }
            else if (IsUserReauth)
            {
                userReauth?.Invoke(UserReauth!);
            }
            else if (IsAccessRevoked)
            {
                accessRevoked?.Invoke(AccessRevoked!);
            }
            else if (IsConnectionError)
            {
                connectionError?.Invoke(ConnectionError!);
            }
            else if (IsGoogleNoDatasource)
            {
                googleNoDatasource?.Invoke(GoogleNoDatasource!);
            }
            else if (IsPermissionChange)
            {
                permissionChange?.Invoke(PermissionChange!);
            }
            else if (IsProcessing)
            {
                processing?.Invoke(Processing!);
            }
            else if (IsLargeRequestProcessing)
            {
                largeRequestProcessing?.Invoke(LargeRequestProcessing!);
            }
            else if (IsLargeRequestSending)
            {
                largeRequestSending?.Invoke(LargeRequestSending!);
            }
            else if (IsRateLimitHit)
            {
                rateLimitHit?.Invoke(RateLimitHit!);
            }
            else if (IsActivity)
            {
                activity?.Invoke(Activity!);
            }
            else if (IsAthlete)
            {
                athlete?.Invoke(Athlete!);
            }
            else if (IsBody)
            {
                body?.Invoke(Body!);
            }
            else if (IsDaily)
            {
                daily?.Invoke(Daily!);
            }
            else if (IsMenstruation)
            {
                menstruation?.Invoke(Menstruation!);
            }
            else if (IsNutrition)
            {
                nutrition?.Invoke(Nutrition!);
            }
            else if (IsSleep)
            {
                sleep?.Invoke(Sleep!);
            }
            else if (IsS3Payload)
            {
                s3Payload?.Invoke(S3Payload!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Healthcheck,
                typeof(global::Terra.HealthcheckEvent),
                AuthSuccess,
                typeof(global::Terra.AuthSuccessEvent),
                AuthError,
                typeof(global::Terra.AuthErrorEvent),
                Deauth,
                typeof(global::Terra.DeauthEvent),
                UserReauth,
                typeof(global::Terra.UserReauthEvent),
                AccessRevoked,
                typeof(global::Terra.AccessRevokedEvent),
                ConnectionError,
                typeof(global::Terra.ConnectionErrorEvent),
                GoogleNoDatasource,
                typeof(global::Terra.GoogleNoDatasourceEvent),
                PermissionChange,
                typeof(global::Terra.PermissionChangeEvent),
                Processing,
                typeof(global::Terra.ProcessingEvent),
                LargeRequestProcessing,
                typeof(global::Terra.LargeRequestProcessingEvent),
                LargeRequestSending,
                typeof(global::Terra.LargeRequestSendingEvent),
                RateLimitHit,
                typeof(global::Terra.RateLimitHitEvent),
                Activity,
                typeof(global::Terra.ActivityEvent),
                Athlete,
                typeof(global::Terra.AthleteEvent),
                Body,
                typeof(global::Terra.BodyEvent),
                Daily,
                typeof(global::Terra.DailyEvent),
                Menstruation,
                typeof(global::Terra.MenstruationEvent),
                Nutrition,
                typeof(global::Terra.NutritionEvent),
                Sleep,
                typeof(global::Terra.SleepEvent),
                S3Payload,
                typeof(global::Terra.S3PayloadEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(WebhookEventType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.HealthcheckEvent?>.Default.Equals(Healthcheck, other.Healthcheck) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.AuthSuccessEvent?>.Default.Equals(AuthSuccess, other.AuthSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.AuthErrorEvent?>.Default.Equals(AuthError, other.AuthError) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.DeauthEvent?>.Default.Equals(Deauth, other.Deauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.UserReauthEvent?>.Default.Equals(UserReauth, other.UserReauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.AccessRevokedEvent?>.Default.Equals(AccessRevoked, other.AccessRevoked) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.ConnectionErrorEvent?>.Default.Equals(ConnectionError, other.ConnectionError) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.GoogleNoDatasourceEvent?>.Default.Equals(GoogleNoDatasource, other.GoogleNoDatasource) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PermissionChangeEvent?>.Default.Equals(PermissionChange, other.PermissionChange) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.ProcessingEvent?>.Default.Equals(Processing, other.Processing) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.LargeRequestProcessingEvent?>.Default.Equals(LargeRequestProcessing, other.LargeRequestProcessing) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.LargeRequestSendingEvent?>.Default.Equals(LargeRequestSending, other.LargeRequestSending) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.RateLimitHitEvent?>.Default.Equals(RateLimitHit, other.RateLimitHit) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.ActivityEvent?>.Default.Equals(Activity, other.Activity) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.AthleteEvent?>.Default.Equals(Athlete, other.Athlete) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.BodyEvent?>.Default.Equals(Body, other.Body) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.DailyEvent?>.Default.Equals(Daily, other.Daily) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.MenstruationEvent?>.Default.Equals(Menstruation, other.Menstruation) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.NutritionEvent?>.Default.Equals(Nutrition, other.Nutrition) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SleepEvent?>.Default.Equals(Sleep, other.Sleep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.S3PayloadEvent?>.Default.Equals(S3Payload, other.S3Payload) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebhookEventType obj1, WebhookEventType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookEventType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebhookEventType obj1, WebhookEventType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookEventType o && Equals(o);
        }
    }
}

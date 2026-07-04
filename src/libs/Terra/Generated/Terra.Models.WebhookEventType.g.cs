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
        /// 
        /// </summary>
        public bool TryPickAuthSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.AuthSuccessEvent? value)
        {
            value = AuthSuccess;
            return IsAuthSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.AuthSuccessEvent PickAuthSuccess() => IsAuthSuccess
            ? AuthSuccess!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthSuccess' but the value was {ToString()}.");

        /// <summary>
        /// Authentication error event, sent when an authentication flow fails or is cancelled
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
        /// 
        /// </summary>
        public bool TryPickAuthError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.AuthErrorEvent? value)
        {
            value = AuthError;
            return IsAuthError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.AuthErrorEvent PickAuthError() => IsAuthError
            ? AuthError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthError' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickDeauth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.DeauthEvent? value)
        {
            value = Deauth;
            return IsDeauth;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.DeauthEvent PickDeauth() => IsDeauth
            ? Deauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deauth' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickUserReauth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.UserReauthEvent? value)
        {
            value = UserReauth;
            return IsUserReauth;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.UserReauthEvent PickUserReauth() => IsUserReauth
            ? UserReauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserReauth' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickAccessRevoked(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.AccessRevokedEvent? value)
        {
            value = AccessRevoked;
            return IsAccessRevoked;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.AccessRevokedEvent PickAccessRevoked() => IsAccessRevoked
            ? AccessRevoked!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AccessRevoked' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConnectionError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.ConnectionErrorEvent? value)
        {
            value = ConnectionError;
            return IsConnectionError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.ConnectionErrorEvent PickConnectionError() => IsConnectionError
            ? ConnectionError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConnectionError' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickPermissionChange(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.PermissionChangeEvent? value)
        {
            value = PermissionChange;
            return IsPermissionChange;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.PermissionChangeEvent PickPermissionChange() => IsPermissionChange
            ? PermissionChange!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PermissionChange' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickLargeRequestProcessing(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.LargeRequestProcessingEvent? value)
        {
            value = LargeRequestProcessing;
            return IsLargeRequestProcessing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.LargeRequestProcessingEvent PickLargeRequestProcessing() => IsLargeRequestProcessing
            ? LargeRequestProcessing!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LargeRequestProcessing' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickLargeRequestSending(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.LargeRequestSendingEvent? value)
        {
            value = LargeRequestSending;
            return IsLargeRequestSending;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.LargeRequestSendingEvent PickLargeRequestSending() => IsLargeRequestSending
            ? LargeRequestSending!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LargeRequestSending' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickActivity(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.ActivityEvent? value)
        {
            value = Activity;
            return IsActivity;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.ActivityEvent PickActivity() => IsActivity
            ? Activity!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Activity' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickAthlete(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.AthleteEvent? value)
        {
            value = Athlete;
            return IsAthlete;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.AthleteEvent PickAthlete() => IsAthlete
            ? Athlete!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Athlete' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickBody(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.BodyEvent? value)
        {
            value = Body;
            return IsBody;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.BodyEvent PickBody() => IsBody
            ? Body!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Body' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickDaily(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.DailyEvent? value)
        {
            value = Daily;
            return IsDaily;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.DailyEvent PickDaily() => IsDaily
            ? Daily!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Daily' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMenstruation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.MenstruationEvent? value)
        {
            value = Menstruation;
            return IsMenstruation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.MenstruationEvent PickMenstruation() => IsMenstruation
            ? Menstruation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Menstruation' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickNutrition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.NutritionEvent? value)
        {
            value = Nutrition;
            return IsNutrition;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.NutritionEvent PickNutrition() => IsNutrition
            ? Nutrition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Nutrition' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickSleep(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SleepEvent? value)
        {
            value = Sleep;
            return IsSleep;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.SleepEvent PickSleep() => IsSleep
            ? Sleep!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sleep' but the value was {ToString()}.");

        /// <summary>
        /// Planned workout data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PlannedWorkoutEvent? PlannedWorkout { get; init; }
#else
        public global::Terra.PlannedWorkoutEvent? PlannedWorkout { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlannedWorkout))]
#endif
        public bool IsPlannedWorkout => PlannedWorkout != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlannedWorkout(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.PlannedWorkoutEvent? value)
        {
            value = PlannedWorkout;
            return IsPlannedWorkout;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.PlannedWorkoutEvent PickPlannedWorkout() => IsPlannedWorkout
            ? PlannedWorkout!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PlannedWorkout' but the value was {ToString()}.");

        /// <summary>
        /// Hormone data event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.HormoneEvent? Hormone { get; init; }
#else
        public global::Terra.HormoneEvent? Hormone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hormone))]
#endif
        public bool IsHormone => Hormone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHormone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.HormoneEvent? value)
        {
            value = Hormone;
            return IsHormone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.HormoneEvent PickHormone() => IsHormone
            ? Hormone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hormone' but the value was {ToString()}.");

        /// <summary>
        /// Lab report completed event: a report finished processing; its normalized results are delivered under `data`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.LabReportCompletedEvent? LabReportCompleted { get; init; }
#else
        public global::Terra.LabReportCompletedEvent? LabReportCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabReportCompleted))]
#endif
        public bool IsLabReportCompleted => LabReportCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLabReportCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.LabReportCompletedEvent? value)
        {
            value = LabReportCompleted;
            return IsLabReportCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.LabReportCompletedEvent PickLabReportCompleted() => IsLabReportCompleted
            ? LabReportCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LabReportCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Lab report failed event: a report terminally failed processing; `data` carries the structured reason.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.LabReportFailedEvent? LabReportFailed { get; init; }
#else
        public global::Terra.LabReportFailedEvent? LabReportFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabReportFailed))]
#endif
        public bool IsLabReportFailed => LabReportFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLabReportFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.LabReportFailedEvent? value)
        {
            value = LabReportFailed;
            return IsLabReportFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.LabReportFailedEvent PickLabReportFailed() => IsLabReportFailed
            ? LabReportFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LabReportFailed' but the value was {ToString()}.");

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
        public bool TryPickS3Payload(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.S3PayloadEvent? value)
        {
            value = S3Payload;
            return IsS3Payload;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.S3PayloadEvent PickS3Payload() => IsS3Payload
            ? S3Payload!
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3Payload' but the value was {ToString()}.");
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
        public static WebhookEventType FromAuthSuccess(global::Terra.AuthSuccessEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromAuthError(global::Terra.AuthErrorEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromDeauth(global::Terra.DeauthEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromUserReauth(global::Terra.UserReauthEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromAccessRevoked(global::Terra.AccessRevokedEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromConnectionError(global::Terra.ConnectionErrorEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromPermissionChange(global::Terra.PermissionChangeEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromLargeRequestProcessing(global::Terra.LargeRequestProcessingEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromLargeRequestSending(global::Terra.LargeRequestSendingEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromActivity(global::Terra.ActivityEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromAthlete(global::Terra.AthleteEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromBody(global::Terra.BodyEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromDaily(global::Terra.DailyEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromMenstruation(global::Terra.MenstruationEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromNutrition(global::Terra.NutritionEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromSleep(global::Terra.SleepEvent? value) => new WebhookEventType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.PlannedWorkoutEvent value) => new WebhookEventType((global::Terra.PlannedWorkoutEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PlannedWorkoutEvent?(WebhookEventType @this) => @this.PlannedWorkout;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.PlannedWorkoutEvent? value)
        {
            PlannedWorkout = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEventType FromPlannedWorkout(global::Terra.PlannedWorkoutEvent? value) => new WebhookEventType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.HormoneEvent value) => new WebhookEventType((global::Terra.HormoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.HormoneEvent?(WebhookEventType @this) => @this.Hormone;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.HormoneEvent? value)
        {
            Hormone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEventType FromHormone(global::Terra.HormoneEvent? value) => new WebhookEventType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.LabReportCompletedEvent value) => new WebhookEventType((global::Terra.LabReportCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.LabReportCompletedEvent?(WebhookEventType @this) => @this.LabReportCompleted;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.LabReportCompletedEvent? value)
        {
            LabReportCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEventType FromLabReportCompleted(global::Terra.LabReportCompletedEvent? value) => new WebhookEventType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEventType(global::Terra.LabReportFailedEvent value) => new WebhookEventType((global::Terra.LabReportFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.LabReportFailedEvent?(WebhookEventType @this) => @this.LabReportFailed;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(global::Terra.LabReportFailedEvent? value)
        {
            LabReportFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEventType FromLabReportFailed(global::Terra.LabReportFailedEvent? value) => new WebhookEventType(value);

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
        public static WebhookEventType FromS3Payload(global::Terra.S3PayloadEvent? value) => new WebhookEventType(value);

        /// <summary>
        /// 
        /// </summary>
        public WebhookEventType(
            global::Terra.AuthSuccessEvent? authSuccess,
            global::Terra.AuthErrorEvent? authError,
            global::Terra.DeauthEvent? deauth,
            global::Terra.UserReauthEvent? userReauth,
            global::Terra.AccessRevokedEvent? accessRevoked,
            global::Terra.ConnectionErrorEvent? connectionError,
            global::Terra.PermissionChangeEvent? permissionChange,
            global::Terra.LargeRequestProcessingEvent? largeRequestProcessing,
            global::Terra.LargeRequestSendingEvent? largeRequestSending,
            global::Terra.ActivityEvent? activity,
            global::Terra.AthleteEvent? athlete,
            global::Terra.BodyEvent? body,
            global::Terra.DailyEvent? daily,
            global::Terra.MenstruationEvent? menstruation,
            global::Terra.NutritionEvent? nutrition,
            global::Terra.SleepEvent? sleep,
            global::Terra.PlannedWorkoutEvent? plannedWorkout,
            global::Terra.HormoneEvent? hormone,
            global::Terra.LabReportCompletedEvent? labReportCompleted,
            global::Terra.LabReportFailedEvent? labReportFailed,
            global::Terra.S3PayloadEvent? s3Payload
            )
        {
            AuthSuccess = authSuccess;
            AuthError = authError;
            Deauth = deauth;
            UserReauth = userReauth;
            AccessRevoked = accessRevoked;
            ConnectionError = connectionError;
            PermissionChange = permissionChange;
            LargeRequestProcessing = largeRequestProcessing;
            LargeRequestSending = largeRequestSending;
            Activity = activity;
            Athlete = athlete;
            Body = body;
            Daily = daily;
            Menstruation = menstruation;
            Nutrition = nutrition;
            Sleep = sleep;
            PlannedWorkout = plannedWorkout;
            Hormone = hormone;
            LabReportCompleted = labReportCompleted;
            LabReportFailed = labReportFailed;
            S3Payload = s3Payload;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            S3Payload as object ??
            LabReportFailed as object ??
            LabReportCompleted as object ??
            Hormone as object ??
            PlannedWorkout as object ??
            Sleep as object ??
            Nutrition as object ??
            Menstruation as object ??
            Daily as object ??
            Body as object ??
            Athlete as object ??
            Activity as object ??
            LargeRequestSending as object ??
            LargeRequestProcessing as object ??
            PermissionChange as object ??
            ConnectionError as object ??
            AccessRevoked as object ??
            UserReauth as object ??
            Deauth as object ??
            AuthError as object ??
            AuthSuccess as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AuthSuccess?.ToString() ??
            AuthError?.ToString() ??
            Deauth?.ToString() ??
            UserReauth?.ToString() ??
            AccessRevoked?.ToString() ??
            ConnectionError?.ToString() ??
            PermissionChange?.ToString() ??
            LargeRequestProcessing?.ToString() ??
            LargeRequestSending?.ToString() ??
            Activity?.ToString() ??
            Athlete?.ToString() ??
            Body?.ToString() ??
            Daily?.ToString() ??
            Menstruation?.ToString() ??
            Nutrition?.ToString() ??
            Sleep?.ToString() ??
            PlannedWorkout?.ToString() ??
            Hormone?.ToString() ??
            LabReportCompleted?.ToString() ??
            LabReportFailed?.ToString() ??
            S3Payload?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && IsHormone && !IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && IsLabReportCompleted && !IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && IsLabReportFailed && !IsS3Payload || !IsAuthSuccess && !IsAuthError && !IsDeauth && !IsUserReauth && !IsAccessRevoked && !IsConnectionError && !IsPermissionChange && !IsLargeRequestProcessing && !IsLargeRequestSending && !IsActivity && !IsAthlete && !IsBody && !IsDaily && !IsMenstruation && !IsNutrition && !IsSleep && !IsPlannedWorkout && !IsHormone && !IsLabReportCompleted && !IsLabReportFailed && IsS3Payload;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.AuthSuccessEvent, TResult>? authSuccess = null,
            global::System.Func<global::Terra.AuthErrorEvent, TResult>? authError = null,
            global::System.Func<global::Terra.DeauthEvent, TResult>? deauth = null,
            global::System.Func<global::Terra.UserReauthEvent, TResult>? userReauth = null,
            global::System.Func<global::Terra.AccessRevokedEvent, TResult>? accessRevoked = null,
            global::System.Func<global::Terra.ConnectionErrorEvent, TResult>? connectionError = null,
            global::System.Func<global::Terra.PermissionChangeEvent, TResult>? permissionChange = null,
            global::System.Func<global::Terra.LargeRequestProcessingEvent, TResult>? largeRequestProcessing = null,
            global::System.Func<global::Terra.LargeRequestSendingEvent, TResult>? largeRequestSending = null,
            global::System.Func<global::Terra.ActivityEvent, TResult>? activity = null,
            global::System.Func<global::Terra.AthleteEvent, TResult>? athlete = null,
            global::System.Func<global::Terra.BodyEvent, TResult>? body = null,
            global::System.Func<global::Terra.DailyEvent, TResult>? daily = null,
            global::System.Func<global::Terra.MenstruationEvent, TResult>? menstruation = null,
            global::System.Func<global::Terra.NutritionEvent, TResult>? nutrition = null,
            global::System.Func<global::Terra.SleepEvent, TResult>? sleep = null,
            global::System.Func<global::Terra.PlannedWorkoutEvent, TResult>? plannedWorkout = null,
            global::System.Func<global::Terra.HormoneEvent, TResult>? hormone = null,
            global::System.Func<global::Terra.LabReportCompletedEvent, TResult>? labReportCompleted = null,
            global::System.Func<global::Terra.LabReportFailedEvent, TResult>? labReportFailed = null,
            global::System.Func<global::Terra.S3PayloadEvent, TResult>? s3Payload = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuthSuccess && authSuccess != null)
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
            else if (IsPermissionChange && permissionChange != null)
            {
                return permissionChange(PermissionChange!);
            }
            else if (IsLargeRequestProcessing && largeRequestProcessing != null)
            {
                return largeRequestProcessing(LargeRequestProcessing!);
            }
            else if (IsLargeRequestSending && largeRequestSending != null)
            {
                return largeRequestSending(LargeRequestSending!);
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
            else if (IsPlannedWorkout && plannedWorkout != null)
            {
                return plannedWorkout(PlannedWorkout!);
            }
            else if (IsHormone && hormone != null)
            {
                return hormone(Hormone!);
            }
            else if (IsLabReportCompleted && labReportCompleted != null)
            {
                return labReportCompleted(LabReportCompleted!);
            }
            else if (IsLabReportFailed && labReportFailed != null)
            {
                return labReportFailed(LabReportFailed!);
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
            global::System.Action<global::Terra.AuthSuccessEvent>? authSuccess = null,

            global::System.Action<global::Terra.AuthErrorEvent>? authError = null,

            global::System.Action<global::Terra.DeauthEvent>? deauth = null,

            global::System.Action<global::Terra.UserReauthEvent>? userReauth = null,

            global::System.Action<global::Terra.AccessRevokedEvent>? accessRevoked = null,

            global::System.Action<global::Terra.ConnectionErrorEvent>? connectionError = null,

            global::System.Action<global::Terra.PermissionChangeEvent>? permissionChange = null,

            global::System.Action<global::Terra.LargeRequestProcessingEvent>? largeRequestProcessing = null,

            global::System.Action<global::Terra.LargeRequestSendingEvent>? largeRequestSending = null,

            global::System.Action<global::Terra.ActivityEvent>? activity = null,

            global::System.Action<global::Terra.AthleteEvent>? athlete = null,

            global::System.Action<global::Terra.BodyEvent>? body = null,

            global::System.Action<global::Terra.DailyEvent>? daily = null,

            global::System.Action<global::Terra.MenstruationEvent>? menstruation = null,

            global::System.Action<global::Terra.NutritionEvent>? nutrition = null,

            global::System.Action<global::Terra.SleepEvent>? sleep = null,

            global::System.Action<global::Terra.PlannedWorkoutEvent>? plannedWorkout = null,

            global::System.Action<global::Terra.HormoneEvent>? hormone = null,

            global::System.Action<global::Terra.LabReportCompletedEvent>? labReportCompleted = null,

            global::System.Action<global::Terra.LabReportFailedEvent>? labReportFailed = null,

            global::System.Action<global::Terra.S3PayloadEvent>? s3Payload = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuthSuccess)
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
            else if (IsPermissionChange)
            {
                permissionChange?.Invoke(PermissionChange!);
            }
            else if (IsLargeRequestProcessing)
            {
                largeRequestProcessing?.Invoke(LargeRequestProcessing!);
            }
            else if (IsLargeRequestSending)
            {
                largeRequestSending?.Invoke(LargeRequestSending!);
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
            else if (IsPlannedWorkout)
            {
                plannedWorkout?.Invoke(PlannedWorkout!);
            }
            else if (IsHormone)
            {
                hormone?.Invoke(Hormone!);
            }
            else if (IsLabReportCompleted)
            {
                labReportCompleted?.Invoke(LabReportCompleted!);
            }
            else if (IsLabReportFailed)
            {
                labReportFailed?.Invoke(LabReportFailed!);
            }
            else if (IsS3Payload)
            {
                s3Payload?.Invoke(S3Payload!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.AuthSuccessEvent>? authSuccess = null,
            global::System.Action<global::Terra.AuthErrorEvent>? authError = null,
            global::System.Action<global::Terra.DeauthEvent>? deauth = null,
            global::System.Action<global::Terra.UserReauthEvent>? userReauth = null,
            global::System.Action<global::Terra.AccessRevokedEvent>? accessRevoked = null,
            global::System.Action<global::Terra.ConnectionErrorEvent>? connectionError = null,
            global::System.Action<global::Terra.PermissionChangeEvent>? permissionChange = null,
            global::System.Action<global::Terra.LargeRequestProcessingEvent>? largeRequestProcessing = null,
            global::System.Action<global::Terra.LargeRequestSendingEvent>? largeRequestSending = null,
            global::System.Action<global::Terra.ActivityEvent>? activity = null,
            global::System.Action<global::Terra.AthleteEvent>? athlete = null,
            global::System.Action<global::Terra.BodyEvent>? body = null,
            global::System.Action<global::Terra.DailyEvent>? daily = null,
            global::System.Action<global::Terra.MenstruationEvent>? menstruation = null,
            global::System.Action<global::Terra.NutritionEvent>? nutrition = null,
            global::System.Action<global::Terra.SleepEvent>? sleep = null,
            global::System.Action<global::Terra.PlannedWorkoutEvent>? plannedWorkout = null,
            global::System.Action<global::Terra.HormoneEvent>? hormone = null,
            global::System.Action<global::Terra.LabReportCompletedEvent>? labReportCompleted = null,
            global::System.Action<global::Terra.LabReportFailedEvent>? labReportFailed = null,
            global::System.Action<global::Terra.S3PayloadEvent>? s3Payload = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuthSuccess)
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
            else if (IsPermissionChange)
            {
                permissionChange?.Invoke(PermissionChange!);
            }
            else if (IsLargeRequestProcessing)
            {
                largeRequestProcessing?.Invoke(LargeRequestProcessing!);
            }
            else if (IsLargeRequestSending)
            {
                largeRequestSending?.Invoke(LargeRequestSending!);
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
            else if (IsPlannedWorkout)
            {
                plannedWorkout?.Invoke(PlannedWorkout!);
            }
            else if (IsHormone)
            {
                hormone?.Invoke(Hormone!);
            }
            else if (IsLabReportCompleted)
            {
                labReportCompleted?.Invoke(LabReportCompleted!);
            }
            else if (IsLabReportFailed)
            {
                labReportFailed?.Invoke(LabReportFailed!);
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
                PermissionChange,
                typeof(global::Terra.PermissionChangeEvent),
                LargeRequestProcessing,
                typeof(global::Terra.LargeRequestProcessingEvent),
                LargeRequestSending,
                typeof(global::Terra.LargeRequestSendingEvent),
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
                PlannedWorkout,
                typeof(global::Terra.PlannedWorkoutEvent),
                Hormone,
                typeof(global::Terra.HormoneEvent),
                LabReportCompleted,
                typeof(global::Terra.LabReportCompletedEvent),
                LabReportFailed,
                typeof(global::Terra.LabReportFailedEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::Terra.AuthSuccessEvent?>.Default.Equals(AuthSuccess, other.AuthSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.AuthErrorEvent?>.Default.Equals(AuthError, other.AuthError) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.DeauthEvent?>.Default.Equals(Deauth, other.Deauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.UserReauthEvent?>.Default.Equals(UserReauth, other.UserReauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.AccessRevokedEvent?>.Default.Equals(AccessRevoked, other.AccessRevoked) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.ConnectionErrorEvent?>.Default.Equals(ConnectionError, other.ConnectionError) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PermissionChangeEvent?>.Default.Equals(PermissionChange, other.PermissionChange) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.LargeRequestProcessingEvent?>.Default.Equals(LargeRequestProcessing, other.LargeRequestProcessing) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.LargeRequestSendingEvent?>.Default.Equals(LargeRequestSending, other.LargeRequestSending) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.ActivityEvent?>.Default.Equals(Activity, other.Activity) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.AthleteEvent?>.Default.Equals(Athlete, other.Athlete) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.BodyEvent?>.Default.Equals(Body, other.Body) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.DailyEvent?>.Default.Equals(Daily, other.Daily) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.MenstruationEvent?>.Default.Equals(Menstruation, other.Menstruation) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.NutritionEvent?>.Default.Equals(Nutrition, other.Nutrition) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SleepEvent?>.Default.Equals(Sleep, other.Sleep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PlannedWorkoutEvent?>.Default.Equals(PlannedWorkout, other.PlannedWorkout) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.HormoneEvent?>.Default.Equals(Hormone, other.Hormone) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.LabReportCompletedEvent?>.Default.Equals(LabReportCompleted, other.LabReportCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.LabReportFailedEvent?>.Default.Equals(LabReportFailed, other.LabReportFailed) &&
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

# CLAUDE.md -- Terra SDK

## Overview

Auto-generated C# SDK for [Terra](https://tryterra.co/) -- a unified wearables aggregation platform that connects 200+ health and fitness data sources (Fitbit, Garmin, Oura, Whoop, Apple Health, etc.) through a single API. 1,005 generated files from the official OpenAPI 3.1.0 spec (converted to 3.0.3 during generation).

## Build & Test

```bash
dotnet build Terra.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Terra uses dual-header authentication (`x-api-key` + `dev-id`):

```csharp
var client = new TerraClient(apiKey, devId); // TERRA_API_KEY + TERRA_DEV_ID env vars
```

The dual-auth constructor clears Bearer authorization and sets both headers on `HttpClient.DefaultRequestHeaders`, which all sub-clients inherit. A single-apiKey constructor also exists for simpler use cases.

## Key Files

- `src/libs/Terra/openapi.yaml` -- Downloaded from `https://raw.githubusercontent.com/tryterra/openapi/refs/heads/master/v5-bundled.yaml`
- `src/libs/Terra/generate.sh` -- Downloads spec, converts 3.1.0 to 3.0.3, removes per-op dev-id params, runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Terra/Generated/` -- **Never edit** -- auto-generated code (1,005 files)
- `src/libs/Terra/TerraClient.Auth.cs` -- Dual-header auth constructor + DefaultRequestHeaders setup
- `src/libs/Terra/Extensions/TerraClientExtensions.AIFunctions.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with dual-auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

**OpenAPI 3.1.0 → 3.0.3 conversion:** The spec uses 3.1.0 features (`$schema`, `$id`, `const`, `examples` arrays) that are converted in `generate.sh` using inline Python:
- `const` values in `oneOf` → `enum` arrays
- `examples` arrays → single `example` value
- `$schema` / `$id` removed
- Version downgraded to 3.0.3

**Auth fix:** Spec defines dual `apiKey` security schemes (`x-api-key` + `dev-id`). Since AutoSDK can't natively handle dual-header auth, we use `--security-scheme Http:Header:Bearer` for constructor generation and override with custom dual-header constructor + DefaultRequestHeaders.

**dev-id parameter removal:** Per-operation `dev-id` header parameters are removed from the spec since auth is handled globally via DefaultRequestHeaders.

## Sub-client Pattern

```csharp
var client = new TerraClient(apiKey, devId);

// Activity data (workouts, exercises)
client.Activity.ActivityFetchAsync(...)    // Fetch activity data
client.Activity.ActivityWriteAsync(...)    // Write activity data

// Sleep tracking
client.Sleep.SleepFetchAsync(...)          // Fetch sleep data

// Body metrics (weight, BMI, vitals)
client.Body.BodyFetchAsync(...)            // Fetch body data
client.Body.BodyWriteAsync(...)            // Write body data
client.Body.BodyDeleteAsync(...)           // Delete body data

// Daily summaries
client.Daily.DailyFetchAsync(...)          // Fetch daily summary

// Nutrition tracking
client.Nutrition.NutritionFetchAsync(...)  // Fetch nutrition data
client.Nutrition.NutritionWriteAsync(...)  // Write nutrition data
client.Nutrition.NutritionDeleteAsync(...) // Delete nutrition data

// Menstruation tracking
client.Menstruation.MenstruationFetchAsync(...)

// Athlete data
client.Athlete.AthleteFetchAsync(...)

// Planned workouts
client.PlannedWorkout.PlannedWorkoutFetchAsync(...)
client.PlannedWorkout.PlannedWorkoutWriteAsync(...)
client.PlannedWorkout.PlannedWorkoutDeleteAsync(...)

// User management
client.User.UserGetInfoForUserIDAsync(...)         // Get user info
client.User.UserGetAllUserIDsAsync(...)            // List all users
client.User.UserGetInfoForMultipleUserIDsAsync(...) // Bulk user info
client.User.UserModifyUserAsync(...)               // Update user

// Authentication
client.Authentication.AuthenticationAuthenticateUserAsync(...)     // Generate auth link
client.Authentication.AuthenticationGenerateWidgetSessionAsync(...) // Widget session
client.Authentication.AuthenticationDeauthenticateUserAsync(...)   // Deauth user
client.Authentication.AuthenticationGenerateAuthTokenAsync(...)    // Generate auth token

// Integrations
client.Integrations.IntegrationsFetchAsync(...)         // List integrations
client.Integrations.IntegrationsDetailedFetchAsync(...) // Detailed integration info
```

## MEAI AIFunction Tools

| Tool | Description |
|------|-------------|
| `AsGetActivityTool()` | Fetch activity/workout data for a user within a date range |
| `AsGetSleepTool()` | Fetch sleep stages, duration, and efficiency data |
| `AsGetBodyTool()` | Fetch body metrics (weight, BMI, vitals, blood pressure) |
| `AsGetDailyTool()` | Fetch aggregated daily summaries (steps, calories, HR stats) |

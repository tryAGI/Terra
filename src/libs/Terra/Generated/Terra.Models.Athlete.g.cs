
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Athlete
    {
        /// <summary>
        /// User's age.<br/>
        /// Example: 28
        /// </summary>
        /// <example>28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public int? Age { get; set; }

        /// <summary>
        /// User's country of residence.<br/>
        /// Example: United States
        /// </summary>
        /// <example>United States</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// User's bio - a short description they display on their profile.<br/>
        /// Example: Passionate runner and cyclist
        /// </summary>
        /// <example>Passionate runner and cyclist</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// User's state of residence.<br/>
        /// Example: California
        /// </summary>
        /// <example>California</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// User's last name.<br/>
        /// Example: Smith
        /// </summary>
        /// <example>Smith</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// User's sex.<br/>
        /// Example: male
        /// </summary>
        /// <example>male</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sex")]
        public string? Sex { get; set; }

        /// <summary>
        /// User's city of residence.<br/>
        /// Example: San Francisco
        /// </summary>
        /// <example>San Francisco</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// User's email.<br/>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// User's date of birth, in ISO8601 format.<br/>
        /// Example: 1999-11-23
        /// </summary>
        /// <example>1999-11-23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_of_birth")]
        public string? DateOfBirth { get; set; }

        /// <summary>
        /// User's first name.<br/>
        /// Example: John
        /// </summary>
        /// <example>John</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// User's gender.<br/>
        /// Example: male
        /// </summary>
        /// <example>male</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// User's account creation date.<br/>
        /// Example: 2023-01-15
        /// </summary>
        /// <example>2023-01-15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined_provider")]
        public string? JoinedProvider { get; set; }

        /// <summary>
        /// Array of devices associated with the user's account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devices")]
        public global::System.Collections.Generic.IList<global::Terra.DeviceData>? Devices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Athlete" /> class.
        /// </summary>
        /// <param name="age">
        /// User's age.<br/>
        /// Example: 28
        /// </param>
        /// <param name="country">
        /// User's country of residence.<br/>
        /// Example: United States
        /// </param>
        /// <param name="bio">
        /// User's bio - a short description they display on their profile.<br/>
        /// Example: Passionate runner and cyclist
        /// </param>
        /// <param name="state">
        /// User's state of residence.<br/>
        /// Example: California
        /// </param>
        /// <param name="lastName">
        /// User's last name.<br/>
        /// Example: Smith
        /// </param>
        /// <param name="sex">
        /// User's sex.<br/>
        /// Example: male
        /// </param>
        /// <param name="city">
        /// User's city of residence.<br/>
        /// Example: San Francisco
        /// </param>
        /// <param name="email">
        /// User's email.<br/>
        /// Example: user@example.com
        /// </param>
        /// <param name="dateOfBirth">
        /// User's date of birth, in ISO8601 format.<br/>
        /// Example: 1999-11-23
        /// </param>
        /// <param name="firstName">
        /// User's first name.<br/>
        /// Example: John
        /// </param>
        /// <param name="gender">
        /// User's gender.<br/>
        /// Example: male
        /// </param>
        /// <param name="joinedProvider">
        /// User's account creation date.<br/>
        /// Example: 2023-01-15
        /// </param>
        /// <param name="devices">
        /// Array of devices associated with the user's account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Athlete(
            int? age,
            string? country,
            string? bio,
            string? state,
            string? lastName,
            string? sex,
            string? city,
            string? email,
            string? dateOfBirth,
            string? firstName,
            string? gender,
            string? joinedProvider,
            global::System.Collections.Generic.IList<global::Terra.DeviceData>? devices)
        {
            this.Age = age;
            this.Country = country;
            this.Bio = bio;
            this.State = state;
            this.LastName = lastName;
            this.Sex = sex;
            this.City = city;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
            this.FirstName = firstName;
            this.Gender = gender;
            this.JoinedProvider = joinedProvider;
            this.Devices = devices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Athlete" /> class.
        /// </summary>
        public Athlete()
        {
        }
    }
}
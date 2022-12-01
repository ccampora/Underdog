using System;
using Microsoft.AspNetCore.Identity;

namespace Underdog.Models.Users;

public class User : IdentityUser<Guid>
{
    public override Guid Id { get; set; }

    public override string UserName { get; set; }

    public override string PhoneNumber { get; set; }

    public string Name { get; set; }
    public string FamilyName { get; set; }
    //public UserStatus Status { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset UpdatedDate { get; set; }

    // [JsonIgnore]
    // public IEnumerable<UserContact> UserContacts { get; set; }

    // [JsonIgnore]
    // public IEnumerable<Fee> FeesCreatedByUser { get; set; }
    // [JsonIgnore]
    // public IEnumerable<Fee> FeesUpdatedByUser { get; set; }

    // [JsonIgnore]
    // public IEnumerable<ExamFee> ExamFeesCreatedByUser { get; set; }
    // [JsonIgnore]
    // public IEnumerable<ExamFee> ExamFeesUpdatedByUser { get; set; }

    // [JsonIgnore]
    // public IEnumerable<StudentExamFee> StudentExamFeesCreatedByUser { get; set; }
    // [JsonIgnore]
    // public IEnumerable<StudentExamFee> StudentExamFeesUpdatedByUser { get; set; }

    // [JsonIgnore]
    // public IEnumerable<Registration> RegistrationsCreatedByUser { get; set; }
    // [JsonIgnore]
    // public IEnumerable<Registration> RegistrationsUpdatedByUser { get; set; }
}

﻿namespace JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1
{
    public class UserSession : BaseModel
    {
        public AccountStatus AccountStatus { get; set; }
        public bool AccountCreated { get; set; } = false;
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;
        public DateTime? LogoutTime { get; set; }
        public string IPAddress { get; set; }
    }
    public enum AccountStatus
    {
        Active,
        Inactive,
        Suspended,
        Locked,
        Pending
    }
}

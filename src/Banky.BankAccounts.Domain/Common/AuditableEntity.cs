using System;

namespace Banky.BankAccounts.Domain.Common
{
    public abstract class AuditableEntity
    {
        public int TenantId { get; set; }
        public string CreatedBy { get; set; }

        public DateTime Created { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
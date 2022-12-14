using Customer.Portal.Web.Models;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Customer.Portal.Web.ViewModels
{
    public class BankCustomerViewModel
    {
        public int Id { get; set; }
        public int FolioNumber { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public string email { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public SourceOfIncome SourceOfIncome { get; set; }
        public int AnnualIncome { get; set; }

        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Pin { get; set; }

        public string Pan { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string MobileNumber { get; set; }
        public string? Telephone { get; set; }

        public string NomineeFirstName { get; set; }
        public string? NomineeLastName { get; set; }
        public string? NomineeRelationship { get; set; }

        [JsonIgnore]
        public IList<AccountViewModel> Accounts { get; set; } = new List<AccountViewModel>();
    }
}

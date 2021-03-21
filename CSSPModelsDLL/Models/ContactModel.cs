using CSSPEnumsDLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class ContactModel : LastUpdateAndContactModel
    {
        public ContactModel()
        {
            ContactTitle = null;
            IsAdmin = false;
            EmailValidated = false;
            Disabled = false;
            IsNew = false;
            SamplingPlanner_ProvincesTVItemID = "";
            EmailList = new List<EmailModel>();
            TelList = new List<TelModel>();
            AddressList = new List<AddressModel>();
        }
        public int ContactID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public string Id { get; set; }
        public int ContactTVItemID { get; set; }
        public string LoginEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initial { get; set; }
        public string CellNumber { get; set; }
        public Nullable<bool> CellNumberConfirmed { get; set; }
        public string WebName { get; set; }
        public Nullable<ContactTitleEnum> ContactTitle { get; set; }
        public bool IsAdmin { get; set; }
        public bool EmailValidated { get; set; }
        public bool Disabled { get; set; }
        public bool IsNew { get; set; }
        public string SamplingPlanner_ProvincesTVItemID { get; set; }
        public string PasswordHash { get; set; }
        public string Token { get; set; }
        public bool? HasInternetConnection { get; set; }
        public bool? IsLoggedIn { get; set; }
        public string GoogleMapKeyHash { get; set; }
        public Nullable<int> AccessFailedCount { get; set; }
        public List<EmailModel> EmailList { get; set; }
        public List<TelModel> TelList { get; set; }
        public List<AddressModel> AddressList { get; set; }
    }
}

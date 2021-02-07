using CSSPEnumsDLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPModelsDLL.Models
{
    public class ResetPasswordModel : LastUpdateAndContactModel
    {
        public ResetPasswordModel()
        {
        }
        public int ResetPasswordID { get; set; }
        public DBCommandEnum DBCommand { get; set; }
        public DateTime ExpireDate_Local { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Code { get; set; }
    }
}

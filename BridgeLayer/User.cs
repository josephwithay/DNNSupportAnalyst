using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLayer
{
    public class User
    {
        public int userID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        [Display(Name = "Name")]
        public string name
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }
        [Display(Name = "Username")]
        public string userName { get; set; }

        [Display(Name = "E-Mail")]
        public string email { get; set; }

        [Display(Name = "Joined")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime joined { get; set; }
    }
}

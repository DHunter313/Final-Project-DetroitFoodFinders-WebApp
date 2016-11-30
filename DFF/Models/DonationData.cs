//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DFF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DonationData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonationData()
        {
            this.MatchUp = new HashSet<MatchUp>();
        }

        public int DonationID { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required, RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }

        [MaxLength(35, ErrorMessage = "Please keep it short, 35 characters")]
        [Required(ErrorMessage = "Please describe your donation")]
        [Display(Name = "Food Type")]
        public string FoodType { get; set; }

        [Required(ErrorMessage = "Please enter a Location")]
        public string Location { get; set; }

        [Display(Name = "Pickup Date")]
        [Required(ErrorMessage = "Please enter a Date")]
        public string PickupDate { get; set; }

        [Required]
        [Display(Name = "Pickup Time")]
        public string PickupTime { get; set; }

        [Display(Name = "Expire Tme")]
        public string ExpireTime { get; set; }

        [Display(Name = "Short Description")]
        public string shortDescription { get; set; }

        public string Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchUp> MatchUp { get; set; }
    }
}
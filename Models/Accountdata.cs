using System;
using System.ComponentModel.DataAnnotations;
namespace Apps.Models

{
     

    public class Accountdata
    {
        [Key]
        public int accountID {get; set;}
        [Required(ErrorMessage="Email is required!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")] 
        public string email  {get; set;}
        [Required(ErrorMessage="Password is required!")]
        [Display(Name="Password")] 
        public string password {get; set;}
        [Required(ErrorMessage="Birthdate is required!")]
        [Display(Name="Birthdate")] 
        public string birthdate {get; set;}
        [Required(ErrorMessage="Owner is required!")]
        [Display(Name="Owner")] 
        public string owner {get; set;}
        [Required(ErrorMessage="Address is required!")]
        [Display(Name="Address")] 
        [StringLength(100)]
        public string address {get; set;}
             

    }         
}
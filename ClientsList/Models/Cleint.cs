using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientsList.Models
{
    public class Cleint
    {
        [Key]
        public int ClientID { get; set; }

        [Required]
        [DisplayName("Client Name")]
        public String ClientName { get; set; }

        [Required]
        [DisplayName("Full Address")]
        public String Address { get; set; }


        [Required]
        [DisplayName("Phone No")]
        public String PhoneNo { get; set; }

        [Required]
        [DisplayName("Model Name")]
        public String ProductModel { get; set; }

        
        [DisplayName("Setup Date")]
        [DataType(DataType.Date)]
        public DateTime? SetupDate { get; set; }

     
        [DisplayName("Old Service Date")]
        [DataType(DataType.Date)]
        public DateTime? OldServiceDate { get; set; }


        [Required]
        [DisplayName("Service Date")]
        [DataType(DataType.Date)]
        public DateTime ServiceDate { get; set; }


        [Required]
        [DisplayName("Next Service Date")]
        [DataType(DataType.Date)]
        public DateTime NextServiceDate { get; set; }

    
        

        public String PaymentType { get; set; }

        public String PaymentAmount{ get; set; }


    }
}
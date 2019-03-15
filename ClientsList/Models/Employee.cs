using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientsList.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

       
        [DisplayName("Employee Name")]
        public String EmployeeName { get; set; }


        public enum Qualification
        {
            Select = 0,
            SSC = 1,
            HSC = 2,
            Honors = 3,
            Masters = 4,
            BSC = 5,
            Diploma=6,
            MSC=7,
            BBA=8,
            MBA=9




        }



        [Display(Name = "Education Qualification")]
        public Qualification Honors { get; set; }


        [Display(Name = "Education Qualification")]
        public Qualification Masters { get; set; }



        [Display(Name = "Education Qualification")]
        public Qualification BSC { get; set; }

        [Display(Name = "Education Qualification")]
        public Qualification Diploma { get; set; }



        [Display(Name = "Education Qualification")]
        public Qualification HSC { get; set; }


        [Display(Name = " Education Qualification")]
        public Qualification SSC { get; set; }
        public enum Broads
        {
            Select = 0,
            Barisal = 1,
            Dhaka = 2,
            Chittagong = 3,
            Sylhet = 4,
            Comilla = 5,
            Rajshahi = 6,
            Dinajpur = 7,
            Madrasah = 8,
            Jessore = 9

        }



        [Display(Name = " Broad")]
        public Broads SBroad { get; set; }


        [Display(Name = " Broad")]
        public Broads HBroad { get; set; }



        [Display(Name = "University Name")]
        public String DVersity { get; set; }

        [Display(Name = "University Name")]
        public String HVersity { get; set; }



        [Display(Name = "University Name")]
        public String MVersity { get; set; }


        [Display(Name = "University Name")]
        public String BVersity { get; set; }


        [Display(Name = "Department Name")]
        public String HVDepartment { get; set; }

        [Display(Name = "Department Name")]
        public String MVDepartment { get; set; }

        [Display(Name = "Department Name")]
        public String BVDepartment { get; set; }

        [Display(Name = "Department Name")]
        public String DDepartment { get; set; }

        [Display(Name = "Year")]
        public String DYear { get; set; }

        [Display(Name = "Year")]
        public String SYear { get; set; }

        [Display(Name = "Year")]
        public String HYear { get; set; }

        [Display(Name = "Year")]
        public String HVYear { get; set; }

        [Display(Name = "Year")]
        public String MVYear { get; set; }


        [Display(Name = "Year")]
        public String BVYear { get; set; }


        [DisplayName("Father Name")]
        public String FatherName { get; set; }

   
        [DisplayName("Mother Name")]
        public String MotherName { get; set; }

       
        [DisplayName("F/M NID No")]
        public String FGovtIdNo{ get; set; }

        [Display(Name = "ID")]
        public String OfficeId { get; set; }

        [Display(Name = "Experience")]
        public String Experience { get; set; }


        public String ImageName { get; set; }

        [Display(Name = "Image File ")]

        public String ImageFile { get; set; }

        [DisplayName("NID/Birth Reg. No")]
        public String GovtIdNo { get; set; }

      


        [DisplayName("Phone No")]
        public String PhoneNo { get; set; }


   
        [DisplayName("Designation")]
        public String Designation { get; set; }

        
        [DisplayName("Present Address")]
        public String PresentAddress { get; set; }

   
        [DisplayName("Permanent Address")]
        public String permanentAddress { get; set; }


      
        [DisplayName("First Reference Name")]
        public string FirstReferenceName { get; set; }


  
        [DisplayName("First Reference Address ")]
        public string FRAddress { get; set; }



      
        [DisplayName("First Reference Phone")]
        public string FRPhone { get; set; }



        [DisplayName("Second Reference Name")]
        public string SecondReferenceName { get; set; }


    
        [DisplayName("Second Reference Address")]
        public string SRAddress { get; set; }


       
        [DisplayName("Second Reference Phone")]
        public string SRPhone { get; set; }


        [DisplayName("Joining Date")]
        [DataType(DataType.Date)]
        public DateTime? JoinDate { get; set; }


        [DisplayName("Resignation Date")]
        [DataType(DataType.Date)]
        public DateTime? ResignationDate { get; set; }


        [DisplayName("Phone No")]
   
        public String Description { get; set; }


    }
}
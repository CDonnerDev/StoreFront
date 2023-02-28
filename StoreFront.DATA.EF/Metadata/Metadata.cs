using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace StoreFront.DATA.EF//.Metadata
{
    //internal class Metadata
    //{
    //}

    public class CategoryMetadata
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(30)]
        public string CategoryName { get; set; } = null!;

        [StringLength(500)]
        [Display(Name ="Description")]
        public string? CategoryDescription { get; set; }
    }

    public class ProductMetadata
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Product")]
        public string ProductName { get; set; } = null!;

        [Required]
        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false)]
        [Range(0, (double)decimal.MaxValue)]
        public decimal ProductPrice { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        [UIHint("MultilineText")]
        public string? ProductDescription { get; set; }


        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int StatusId { get; set; }

        [StringLength(75)]
        [Display(Name = "Image")]
        public string? ProductImage { get; set; }

        [Required]
        [Display(Name = "In Stock")]
        [Range(0, short.MaxValue)]
        public short UnitsInStock { get; set; }

        [Display(Name = "Discontinued?")]
        public bool IsDiscontinued { get; set; }
    }

    public class ProductStatusMetadata
    {
        public int StatusId { get; set; }

        [Required]
        [Display(Name= "Name")]
        [StringLength(20)]
        public string StatusName { get; set; } = null!;

        [Required]
        [Display(Name ="Description")]
        [StringLength(500)]
        public string StatusDescription { get; set; } = null!;

        [Required]
        [Display(Name ="Discontinued")]
        public bool Discontinued { get; set; }
    }

    public class SupplierMetadata
    {
        public int SupplierId { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Supplier Name")]
        public string CompanyName { get; set; } = null!;

        [Display(Name = "Contact Name")]
        [StringLength(30)]
        public string? ContactName { get; set; }

        [Display(Name ="Contact's Title")]
        [StringLength(30)]
        public string? ContactTitle { get; set; }

        [Display(Name ="Supplier Address")]
        [StringLength(60)]
        public string? Address { get; set; }

        [StringLength(25)]
        [Display(Name ="Supplier City")]
        public string? City { get; set; }

        [StringLength(20)]
        [Display(Name = "Supplier Region")]
        public string? Region { get; set; }

        [Display(Name ="Supplier Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }

        [Display(Name ="Supplier Country")]
        public string? Country { get; set; }

        [StringLength(24)]
        [Display(Name ="Supplier Phone Number")]
        public string? Phone { get; set; }

        [StringLength(24)]
        [Display(Name ="Supplier Fax")]
        public string? Fax { get; set; }

        [Display(Name ="Homepage")]
        public string? Homepage { get; set; }
    }

}

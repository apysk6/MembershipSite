﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(2500)]
        public string Description { get; set; }
        [MaxLength(1024)]
        public string Url { get; set; }
        [MaxLength(1024)]
        [DisplayName("Image URL")]
        public string ImageUrl { get; set; }
        [AllowHtml]
        public string HTML { get; set; }
        [DefaultValue(0)]
        [DisplayName("Wait Days")]
        public int WaitDays { get; set; }
        [DisplayName("HTML Code")]
        public string HTMLShort
        {
            get
            {
                return HTML == null || HTML.Length < 50
                    ? HTML : HTML.Substring(0, 50);
            }
        }
        [DisplayName("Product ID")]
        public int ProductId { get; set; }
        [DisplayName("Item Type ID")]
        public int ItemTypeId { get; set; }
        [DisplayName("Section ID")]
        public int SectionId { get; set; }
        [DisplayName("Part ID")]
        public int PartId { get; set; }
        [DisplayName("Is Free")]
        public bool IsFree { get; set; }

        [DisplayName("Item Type")]
        public ICollection<ItemType> ItemTypes { get; set; }
        [DisplayName("Sections")]
        public ICollection<Section> Sections { get; set; }
        [DisplayName("Parts")]
        public ICollection<Part> Parts { get; set; }
    }



}

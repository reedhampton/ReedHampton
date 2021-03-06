﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReedHampton.Models
{
    public class DevelopmentProjectViewModel
    {
        //-----------------------For Image------------------------------------------//

        [DataType(DataType.Upload)]
        [Display(Name = "Thumbnail")]
        public HttpPostedFileBase ProjectThumbnailUpload { get; set; }

        //-----------------------In Thumbnail view------------------------------------------//

        [Required]
        [Display(Name = "Short Title")]
        public string ShortName { get; set; }

        [Required]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }

        //-----------------------In exanded view------------------------------------------//

        [Required]
        [Display(Name = "Long Title")]
        public string LongName { get; set; }

        [Required]
        [Display(Name = "Category(School/Work/Independant)")]
        public string Category { get; set; }

        [Required]
        [Display(Name = "Date")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }

        [Display(Name = "Skills(Select all that apply)")]
        public string SkillsNeeded { get; set; }

        [Display(Name = "GitHub URL")]
        public string GitHubUrl { get; set; }

        [Display(Name = "Project URL")]
        public string ProjectUrl { get; set; }

        public skills SkillList { get; set; }

        public enum skills
        {
            HTML = 1,
            CSS,
            Javascript,
            Ruby,
            Rails,
            ASPnet,
            C
        }
    }
}
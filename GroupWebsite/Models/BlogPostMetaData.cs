using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupWebsite.Models
{
    public class BlogPostMetaData
    {

      

        public System.Guid BlogID { get; set; }
        [Required(ErrorMessage ="*Required")]
        public string Title { get; set; }
        [Required(ErrorMessage ="*Required")]
        public string Body { get; set; }
        public string Picture { get; set; }
        [Required(ErrorMessage = "Required")]
        public bool HasPicture { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Published")]
        public System.DateTime Date { get; set; }


        public virtual ICollection<LinkingTableForMPB> LinkingTableForMPBs { get; set; }


    }


    [MetadataType(typeof(BlogPostMetaData))]

    public partial class BlogPost { }
}
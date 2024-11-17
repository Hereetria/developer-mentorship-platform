using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ArticleContent
    {
        public int ArticleContentId { get; set; }

        [RegularExpression(@"^(ImageUrl|Blockquote|Text|Header)$", ErrorMessage = "The 'Data' value must be one of the following: 'ImageUrl', 'Blockquote', 'Text', or 'Header'. Please enter a valid value.")]
        public string Type { get; set; }

        public string Data { get; set; }
        public int Order { get; set; }

        public int ArticleDetailId { get; set; }
        public ArticleDetail ArticleDetail { get; set; }

        public ICollection<Subsection> Subsections = new List<Subsection>();
    }
}

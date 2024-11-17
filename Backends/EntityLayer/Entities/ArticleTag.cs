using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ArticleTag
    {
        public int ArticleTagId { get; set; }

        public int ArticleDetailId { get; set; }
        public ArticleDetail ArticleDetail { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }

}

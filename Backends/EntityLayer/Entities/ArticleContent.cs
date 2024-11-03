using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ArticleContent
    {
        public int ArticleContentId { get; set; }
        public ContentType Type { get; set; }
        public string Data { get; set; }
        public int Order { get; set; }

        public int ArticleDetailId { get; set; }
        public ArticleDetail ArticleDetail { get; set; }
    }
}

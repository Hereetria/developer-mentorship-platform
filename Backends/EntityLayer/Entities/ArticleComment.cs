using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ArticleComment
    {
        public int ArticleCommentId { get; set; }
        public string Name { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Content { get; set; }

        public int? ParentCommentId { get; set; }
        public ArticleComment ParentComment { get; set; }
        public List<ArticleComment> Replies { get; set; } = new List<ArticleComment>();

        public int ArticleDetailId { get; set; }
        public ArticleDetail ArticleDetail { get; set; }
    }
}

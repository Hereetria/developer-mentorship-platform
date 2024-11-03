using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ArticleDetail
    {
        public int ArticleDetailId { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ArticleComment> ArticleComments {  get; set; } = new List<ArticleComment>();

        public ICollection<ArticleContent> ArticleContents { get; set; } = new List<ArticleContent>();

        public ICollection<ArticleTag> ArticleTags { get; set; } = new List<ArticleTag>();
    }
}

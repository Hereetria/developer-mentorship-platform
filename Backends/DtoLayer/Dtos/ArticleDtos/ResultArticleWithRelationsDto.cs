using DtoLayer.Dtos.ArticleDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ArticleDtos
{
    public class ResultArticleWithRelationsDto
    {
        public int ArticleId { get; set; }
        public string ImageUrl { get; set; }
        public string Header { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CommentCount { get; set; }
        public string Summary { get; set; }
        public int CategoryId { get; set; }
        public ResultArticleDetailWithRelationsDto ArticleDetailWithRelations { get; set; }
    }
}

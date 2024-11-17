using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using MentorProjectWebApp.Dtos.ArticleDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.CategoryDtos
{
    public class ResultCategoryWithRelationsDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public List<ResultArticleWithRelationsDto> ArticleWithRelations { get; set; } = new List<ResultArticleWithRelationsDto>();
    }

}

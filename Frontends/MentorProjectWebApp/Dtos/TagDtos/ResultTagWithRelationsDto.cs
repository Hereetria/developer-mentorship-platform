using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.TagDtos
{
    public class ResultTagWithRelationsDto
    {
        public int TagId { get; set; }
        public string Name { get; set; }

        public ICollection<ResultArticleDetailDto> ArticleDetails { get; set; } = new List<ResultArticleDetailDto>();
    }
}

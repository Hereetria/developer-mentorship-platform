using DtoLayer.Dtos.ArticleDetailDtos;
using DtoLayer.Dtos.TagDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ArticleTagDtos
{
    public class ResultArticleTagWithRelationsDto
    {
        public int ArticleTagId { get; set; }

        public int ArticleDetailId { get; set; }
        public ICollection<ResultArticleDetailDto> ArticleDetails { get; set; } = new List<ResultArticleDetailDto>();

        public int TagId { get; set; }
        public ICollection<ResultTagDto> Tags { get; set; } = new List<ResultTagDto>();
    }
}

using DtoLayer.Dtos.ArticleDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.TagDtos
{
    public class ResultTagWithRelationsByIdDto
    {
        public int TagId { get; set; }
        public string Name { get; set; }

        public ICollection<ResultArticleDetailDto> ArticleDetails { get; set; } = new List<ResultArticleDetailDto>();
    }
}

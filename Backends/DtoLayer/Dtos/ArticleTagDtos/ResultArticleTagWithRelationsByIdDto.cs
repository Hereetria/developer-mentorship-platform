using DtoLayer.Dtos.ArticleDetailDtos;
using DtoLayer.Dtos.TagDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ArticleTagDtos
{
    public class ResultArticleTagWithRelationsByIdDto
    {
        public int ArticleTagId { get; set; }

        public int ArticleDetailId { get; set; }
        public ResultArticleDetailDto ArticleDetail { get; set; }

        public int TagId { get; set; }
        public ResultTagDto Tag { get; set; }
    }
}

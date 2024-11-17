using DtoLayer.Dtos.ArticleCommentDtos;
using DtoLayer.Dtos.ArticleContentDtos;
using DtoLayer.Dtos.ArticleDtos;
using DtoLayer.Dtos.ArticleTagDtos;
using DtoLayer.Dtos.CategoryDtos;
using DtoLayer.Dtos.TagDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ArticleDetailDtos
{
    public class ResultArticleDetailWithRelationsDto
    {
        public int ArticleDetailId { get; set; }
        public int ArticleId { get; set; }
        public ICollection<ResultArticleCommentDto> ArticleComments { get; set; } = new List<ResultArticleCommentDto>();
        public ICollection<ResultArticleContentDto> ArticleContents { get; set; } = new List<ResultArticleContentDto>();
        public ICollection<ResultTagDto> Tags { get; set; } = new List<ResultTagDto>();
    }
}

using MentorProjectWebApp.Dtos.ArticleCommentDtos;
using MentorProjectWebApp.Dtos.ArticleContentDtos;
using MentorProjectWebApp.Dtos.TagDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.ArticleDetailDtos
{
    public class ResultArticleDetailWithRelationsByIdDto
    {
        public int ArticleDetailId { get; set; }
        public int ArticleId { get; set; }
        public ICollection<ResultArticleCommentDto> ArticleComments { get; set; } = new List<ResultArticleCommentDto>();
        public ICollection<ResultArticleContentDto> ArticleContents { get; set; } = new List<ResultArticleContentDto>();
        public ICollection<ResultTagDto> Tags { get; set; } = new List<ResultTagDto>();
    }
}

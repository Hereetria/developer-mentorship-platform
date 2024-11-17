using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using MentorProjectWebApp.Dtos.TagDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorProjectWebApp.Dtos.ArticleTagDtos
{
    public class ResultArticleTagWithRelationsDto
    {
        public int ArticleTagId { get; set; }

        public int ArticleDetailId { get; set; }
        public ResultArticleDetailDto ArticleDetail { get; set; }

        public int TagId { get; set; }
        public ResultTagDto Tag { get; set; }
    }
}

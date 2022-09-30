using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretBasic.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }

        public string UserFullName { get; set; }

        public int RatingProduct { get; set; }

        public int ProductId { get; set; }

        public virtual Song Song { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votedress.Entities.VeritabaniModellerim
{
    public class ProductCommentReplyLike
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }
        public DateTime LikeDate { get; set; }

        public virtual VotedressUser VotedressUser { get; set; }
        public virtual ProductCommentReply ProductCommentReply { get; set; }


    }
}

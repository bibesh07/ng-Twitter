using Models.Core.Features.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibray.Core.Features.Tweets
{
    public class Tweet
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
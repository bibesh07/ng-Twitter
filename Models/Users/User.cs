using ClassLibray.Core.Features.Tweets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Core.Features.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Bio { get; set; }

        public string Website { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DateJoined { get; set; }

        public IEnumerable<Tweet> Tweets { get; set; }
    }
}

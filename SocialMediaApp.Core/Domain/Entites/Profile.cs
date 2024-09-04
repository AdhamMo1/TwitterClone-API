﻿using SocialMediaApp.Core.Domain.IdentityEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Core.Domain.Entites
{
    public class Profile
    {
        public Guid ProfileID { get; set; }
        public string ProfileImgURL { get; set; }
        public string ProfileBackgroundURL { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public long TotalFollowing {  get; set; }
        public long TotalFollowers { get; set; }
        public long TotalTweets {  get; set; }
        public Guid UserID { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Tweet> Tweets { get; set; } = new List<Tweet>();
        public ICollection<Retweet> Retweets { get; set; } = new List<Retweet>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<ConnectionProfile> ConnectionProfiles { get; set; } = new List<ConnectionProfile>();
        public ICollection<UserConnections> UserConnections { get; set; } = new List<UserConnections>();
    }
}
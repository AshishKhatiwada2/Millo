using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    public class MilloProfile
    {
        public int Id { get; set; }
        public string AboutMe { get; set; }
        public string Activities { get; set; }
        public string AffiliationCount { get; set; }
        public DateTime Birthday { get; set; }
        public string FavoriteMovies { get; set; }
        public string FavoriteBooks { get; set; }
        public string FavoriteMusic { get; set; }
        public string FavoriteTVShows { get; set; }
        public string FavoriteQuotes { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string MiddleName { get; set; }
        public string Interest { get; set; }
        public string IsApplicationUser { get; set; }
        public int NotesCount { get; set; }
        public string PictureBigURL { get; set; }
        public string PictureSmallURL { get; set; }
        public string PictureURL { get; set; }
        public string PoliticalViews { get; set; }
        public string Religion { get; set; }
        public int SchoolCount { get; set; }
        public string SignificantOtherId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UserId { get; set; }
        public int WallCount { get; set; }
        public string WebAddFriendLink { get; set; }
        public string WebNotesByUserLink { get; set; }
        public string WebPicturesByUserLink { get; set; }
        public string WebPicturesOfUserLink { get; set; }
        public string WebPokeLink { get; set; }
        public string WebPostOnUserWallLink { get; set; }
        public string WebSendMessageLink { get; set; }
        public int WorkPlaceCount { get; set; }
        public int FriendsCount { get; set; }
        public int FollowingCount { get; set; }
        public int FollowersCount { get; set; }
    }
}
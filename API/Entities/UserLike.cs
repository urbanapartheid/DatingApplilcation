﻿namespace API.Entities
{
    public class UserLike
    {
        #region Properties
        public AppUser SourceUser { get; set; }

        public int SourceUserId { get; set; }

        public AppUser LikedUser { get; set; }

        public int LikedUserId { get; set; } 
        #endregion
    }
}

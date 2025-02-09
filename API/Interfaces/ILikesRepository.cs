﻿using API.DTOs;
using API.Entities;
using API.Helpers;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        #region Methods
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);

        Task<AppUser> GetUserWithLikes(int userId);

        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams); 
        #endregion
    }
}

﻿using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;
using System.Linq;

namespace API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        #region CTOR
        public AutoMapperProfile()
        {
            CreateMap<AppUser, MemberDto>()
               .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                    src.Photos.FirstOrDefault(x => x.IsMain).Url))
               .ForMember(dest => dest.Age, opt => opt.MapFrom(src =>
                    src.DateOfBirth.CalculateAge()));

            CreateMap<Photo, PhotoDto>();

            CreateMap<MemberUpdateDto, AppUser>();

            CreateMap<RegisterDto, AppUser>();

            CreateMap<Message, MessageDto>()
              .ForMember(dest => dest.SenderPhotoUrl, opt => opt.MapFrom(src =>
                  src.Sender.Photos.FirstOrDefault(x => x.IsMain).Url))
              .ForMember(dest => dest.RecipientPhotoUrl, opt => opt.MapFrom(src =>
                  src.Recipient.Photos.FirstOrDefault(x => x.IsMain).Url));
            CreateMap<MessageDto, Message>();
        } 
        #endregion
    }
}

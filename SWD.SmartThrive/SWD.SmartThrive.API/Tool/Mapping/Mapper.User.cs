﻿using AutoMapper;
using SWD.SmartThrive.API.RequestModel;
using SWD.SmartThrive.Repositories.Data.Table;
using SWD.SmartThrive.Services.Model;

namespace Smart_Thrive.Tool.Mapping
{
    public partial class Mapper : Profile
    {
        public void UserMapping()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<UserModel, UserRequest>().ReverseMap();
        }
    }
}

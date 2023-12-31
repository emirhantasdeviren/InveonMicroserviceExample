﻿using Inveon.Web.Models.Dto;
using Inveon.Web.Models;

namespace Inveon.Web.Services.IService;

public interface IBaseService
{
    Task<ResponseDto?> SendAsync(RequestDto reqDto);
}

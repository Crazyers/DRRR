﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRRR.Server.Dtos
{
    /// <summary>
    /// 用户注册请求DTO
    /// </summary>
    public class UserRegisterRequestDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 验证码ID
        /// </summary>
        public string CaptchaId { get; set; }

        /// <summary>
        /// 验证码内容
        /// </summary>
        public string CaptchaText { get; set; }
    }
}

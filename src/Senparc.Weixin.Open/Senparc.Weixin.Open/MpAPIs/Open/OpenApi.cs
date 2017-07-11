﻿/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc

    文件名：OpenApi.cs
    文件功能描述：微信开放平台帐号管理接口
    https://open.weixin.qq.com/cgi-bin/showdocument?action=dir_list&t=resource/res_list&verify=1&id=open1498704804_iARAL&token=&lang=zh_CN

    创建标识：Senparc - 20170629
    
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senparc.Weixin.CommonAPIs;
using Senparc.Weixin.Entities;
using Senparc.Weixin.HttpUtility;

namespace Senparc.Weixin.Open.MpAPIs.Open
{
    public static class OpenApi
    {
        #region 同步接口

        /// <summary>
        /// 创建开放平台帐号并绑定公众号/小程序。
        /// 该API用于创建一个开放平台帐号，并将一个尚未绑定开放平台帐号的公众号/小程序绑定至该开放平台帐号上。新创建的开放平台帐号的主体信息将设置为与之绑定的公众号或小程序的主体。
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="appId">授权公众号或小程序的appid</param>
        /// <returns></returns>
        public static CreateJsonResult Create(string accessToken, string appId)
        {
            var urlFormat = "https://api.weixin.qq.com/cgi-bin/open/create?access_token={0}";
            var data = new { appid = appId };
            return CommonJsonSend.Send<CreateJsonResult>(accessToken, urlFormat, data);
        }

        /// <summary>
        /// 将公众号/小程序绑定到开放平台帐号下
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="appId">授权公众号或小程序的appid</param>
        /// <param name="openAppid">开放平台帐号appid</param>
        /// <returns></returns>
        public static WxJsonResult Bind(string accessToken, string appId, string openAppid)
        {
            var urlFormat = "https://api.weixin.qq.com/cgi-bin/open/bind?access_token={0}";
            var data = new { appid = appId, open_appid = openAppid };
            return CommonJsonSend.Send<WxJsonResult>(accessToken, urlFormat, data);
        }

        #endregion

        #region 异步接口

        /// <summary>
        /// 【异步方法】创建开放平台帐号并绑定公众号/小程序。
        /// 该API用于创建一个开放平台帐号，并将一个尚未绑定开放平台帐号的公众号/小程序绑定至该开放平台帐号上。新创建的开放平台帐号的主体信息将设置为与之绑定的公众号或小程序的主体。
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="appId">授权公众号或小程序的appid</param>
        /// <returns></returns>
        public static async Task<CreateJsonResult> CreateAsync(string accessToken, string appId)
        {
            var urlFormat = "https://api.weixin.qq.com/cgi-bin/open/create?access_token={0}";
            var data = new { appid = appId };
            return await CommonJsonSend.SendAsync<CreateJsonResult>(accessToken, urlFormat, data);
        }

        /// <summary>
        /// 【异步方法】将公众号/小程序绑定到开放平台帐号下
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="appId">授权公众号或小程序的appid</param>
        /// <param name="openAppid">开放平台帐号appid</param>
        /// <returns></returns>
        public static async Task<WxJsonResult> BindAsync(string accessToken, string appId, string openAppid)
        {
            var urlFormat = "https://api.weixin.qq.com/cgi-bin/open/bind?access_token={0}";
            var data = new { appid = appId, open_appid = openAppid };
            return await CommonJsonSend.SendAsync<WxJsonResult>(accessToken, urlFormat, data);
        }

        #endregion
    }
}

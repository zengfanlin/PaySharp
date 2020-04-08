

using System;
using Newtonsoft.Json;
using PaySharp.Core.Request;

namespace PaySharp.Alipay.Response
{
    [Serializable]
    public class AlipayOpenAuthTokenAppResponse : BaseResponse
    {
        /// <summary>
        ///     应用授权令牌
        /// </summary>
        [JsonProperty("app_auth_token")]
        public string AppAuthToken { get; set; }

        /// <summary>
        ///     刷新令牌
        /// </summary>
        [JsonProperty("app_refresh_token")]
        public string AppRefreshToken { get; set; }

        /// <summary>
        ///     授权商户的appid
        /// </summary>
        [JsonProperty("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        ///     应用授权令牌的有效时间（从接口调用时间作为起始时间），单位到秒
        /// </summary>
        [JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        ///     刷新令牌的有效时间（从接口调用时间作为起始时间），单位到秒
        /// </summary>
        [JsonProperty("re_expires_in")]
        public string ReExpiresIn { get; set; }

        /// <summary>
        ///     授权商户的user_id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        ///     错误码
        ///     对应 ErrCode
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        ///     错误信息
        ///     对应 ErrMsg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        ///     子错误码
        ///     对应 SubErrCode
        /// </summary>
        [JsonProperty("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        ///     子错误信息
        ///     对应 SubErrMsg
        /// </summary>
        [JsonProperty("sub_msg")]
        public string SubMsg { get; set; }

        /// <summary>
        ///     响应原始内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        ///     响应结果是否错误
        /// </summary>
        public bool IsError => !string.IsNullOrEmpty(SubCode);

        public string Raw { get; set; }

        internal override void Execute<TModel, TResponse>(Merchant merchant, Request<TModel, TResponse> request)
        {
        }
    }
}

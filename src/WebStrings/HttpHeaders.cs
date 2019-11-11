// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using HN = Microsoft.Net.Http.Headers.HeaderNames;

// ReSharper disable once CheckNamespace
public static class HttpHeaders
{
    /// <summary>
    ///     <see href="https://www.w3.org/TR/server-timing/" />
    /// </summary>
    public const string ServerTiming = "Server-Timing";

    /// <summary>
    ///     <see href="https://www.w3.org/TR/server-timing/" />
    /// </summary>
    public const string TimingAllowOrigin = "Timing-Allow-Origin";

    /// <summary>
    ///     <see href="https://github.com/Microsoft/api-guidelines/blob/master/Guidelines.md#75-standard-request-headers" />
    /// </summary>
    public const string Prefer = "Prefer";

    /// <summary>
    ///     <see href="https://github.com/Microsoft/api-guidelines/blob/master/Guidelines.md#75-standard-request-headers" />
    /// </summary>
    public const string PreferenceApplied = "Preference-Applied";

    /// <summary>
    ///     <see href="https://tools.ietf.org/html/rfc5988" />
    /// </summary>
    public const string Link = "Link";

    /// <summary>
    ///     <see href="https://www.w3.org/TR/trace-context/" />
    /// </summary>
    public const string TraceParent = "Trace-Parent";

    public const string MethodOverride = "X-HTTP-Method-Override";
    public const string Action = "X-Action";
    public const string TotalCount = "X-Total-Count";
    public const string TotalPages = "X-Total-Pages";

    #region Microsoft.Net.Http.HeaderNames

    public const string Accept = "Accept";
    public const string AcceptCharset = "Accept-Charset";
    public const string AcceptEncoding = "Accept-Encoding";
    public const string AcceptLanguage = "Accept-Language";
    public const string AcceptRanges = "Accept-Ranges";
    public const string AccessControlAllowCredentials = "Access-Control-Allow-Credentials";
    public const string AccessControlAllowHeaders = "Access-Control-Allow-Headers";
    public const string AccessControlAllowMethods = "Access-Control-Allow-Methods";
    public const string AccessControlAllowOrigin = "Access-Control-Allow-Origin";
    public const string AccessControlExposeHeaders = "Access-Control-Expose-Headers";
    public const string AccessControlMaxAge = "Access-Control-Max-Age";
    public const string AccessControlRequestHeaders = "Access-Control-Request-Headers";
    public const string AccessControlRequestMethod = "Access-Control-Request-Method";
    public const string Age = "Age";
    public const string Allow = "Allow";
    public const string Authority = ":authority";
    public const string Authorization = "Authorization";
    public const string CacheControl = "Cache-Control";
    public const string Connection = "Connection";
    public const string ContentDisposition = "Content-Disposition";
    public const string ContentEncoding = "Content-Encoding";
    public const string ContentLanguage = "Content-Language";
    public const string ContentLength = "Content-Length";
    public const string ContentLocation = "Content-Location";
    public const string ContentMD5 = "Content-MD5";
    public const string ContentRange = "Content-Range";
    public const string ContentSecurityPolicy = "Content-Security-Policy";
    public const string ContentSecurityPolicyReportOnly = "Content-Security-Policy-Report-Only";
    public const string ContentType = "Content-Type";
    public const string Cookie = "Cookie";
    public const string Date = "Date";
    public const string ETag = "ETag";
    public const string Expires = "Expires";
    public const string Expect = "Expect";
    public const string From = "From";
    public const string Host = "Host";
    public const string IfMatch = "If-Match";
    public const string IfModifiedSince = "If-Modified-Since";
    public const string IfNoneMatch = "If-None-Match";
    public const string IfRange = "If-Range";
    public const string IfUnmodifiedSince = "If-Unmodified-Since";
    public const string LastModified = "Last-Modified";
    public const string Location = "Location";
    public const string MaxForwards = "Max-Forwards";
    public const string Method = ":method";
    public const string Origin = "Origin";
    public const string Path = ":path";
    public const string Pragma = "Pragma";
    public const string ProxyAuthenticate = "Proxy-Authenticate";
    public const string ProxyAuthorization = "Proxy-Authorization";
    public const string Range = "Range";
    public const string Referer = "Referer";
    public const string RetryAfter = "Retry-After";
    public const string Scheme = ":scheme";
    public const string Server = "Server";
    public const string SetCookie = "Set-Cookie";
    public const string Status = ":status";
    public const string StrictTransportSecurity = "Strict-Transport-Security";
    public const string TE = "TE";
    public const string Trailer = "Trailer";
    public const string TransferEncoding = "Transfer-Encoding";
    public const string Upgrade = "Upgrade";
    public const string UserAgent = "User-Agent";
    public const string Vary = "Vary";
    public const string Via = "Via";
    public const string Warning = "Warning";
    public const string WebSocketSubProtocols = "Sec-WebSocket-Protocol";
    public const string WWWAuthenticate = "WWW-Authenticate";

    #endregion
}
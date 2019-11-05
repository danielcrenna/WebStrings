// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using HN = Microsoft.Net.Http.Headers.HeaderNames;

// ReSharper disable once CheckNamespace
public static class HeaderNames
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

    public const string Accept = HN.Accept;
    public const string AcceptCharset = HN.AcceptCharset;
    public const string AcceptEncoding = HN.AcceptEncoding;
    public const string AcceptLanguage = HN.AcceptLanguage;
    public const string AcceptRanges = HN.AcceptRanges;
    public const string AccessControlAllowCredentials = HN.AccessControlAllowCredentials;
    public const string AccessControlAllowHeaders = HN.AccessControlAllowHeaders;
    public const string AccessControlAllowMethods = HN.AccessControlAllowMethods;
    public const string AccessControlAllowOrigin = HN.AccessControlAllowOrigin;
    public const string AccessControlExposeHeaders = HN.AccessControlExposeHeaders;
    public const string AccessControlMaxAge = HN.AccessControlMaxAge;
    public const string AccessControlRequestHeaders = HN.AccessControlRequestHeaders;
    public const string AccessControlRequestMethod = HN.AccessControlRequestMethod;
    public const string Age = HN.Age;
    public const string Allow = HN.Allow;
    public const string Authority = HN.Authority;
    public const string Authorization = HN.Authorization;
    public const string CacheControl = HN.CacheControl;
    public const string Connection = HN.Connection;
    public const string ContentDisposition = HN.ContentDisposition;
    public const string ContentEncoding = HN.ContentEncoding;
    public const string ContentLanguage = HN.ContentLanguage;
    public const string ContentLength = HN.ContentLength;
    public const string ContentLocation = HN.ContentLocation;
    public const string ContentMD5 = HN.ContentMD5;
    public const string ContentRange = HN.ContentRange;
    public const string ContentSecurityPolicy = HN.ContentSecurityPolicy;
    public const string ContentSecurityPolicyReportOnly = HN.ContentSecurityPolicyReportOnly;
    public const string ContentType = HN.ContentType;
    public const string Cookie = HN.Cookie;
    public const string Date = HN.Date;
    public const string ETag = HN.ETag;
    public const string Expires = HN.Expires;
    public const string Expect = HN.Expect;
    public const string From = HN.From;
    public const string Host = HN.Host;
    public const string IfMatch = HN.IfMatch;
    public const string IfModifiedSince = HN.IfModifiedSince;
    public const string IfNoneMatch = HN.IfNoneMatch;
    public const string IfRange = HN.IfRange;
    public const string IfUnmodifiedSince = HN.IfUnmodifiedSince;
    public const string LastModified = HN.LastModified;
    public const string Location = HN.Location;
    public const string MaxForwards = HN.MaxForwards;
    public const string Method = HN.Method;
    public const string Origin = HN.Origin;
    public const string Path = HN.Path;
    public const string Pragma = HN.Pragma;
    public const string ProxyAuthenticate = HN.ProxyAuthenticate;
    public const string ProxyAuthorization = HN.ProxyAuthorization;
    public const string Range = HN.Range;
    public const string Referer = HN.Referer;
    public const string RetryAfter = HN.RetryAfter;
    public const string Scheme = HN.Scheme;
    public const string Server = HN.Server;
    public const string SetCookie = HN.SetCookie;
    public const string Status = HN.Status;
    public const string StrictTransportSecurity = HN.StrictTransportSecurity;
    public const string TE = HN.TE;
    public const string Trailer = HN.Trailer;
    public const string TransferEncoding = HN.TransferEncoding;
    public const string Upgrade = HN.Upgrade;
    public const string UserAgent = HN.UserAgent;
    public const string Vary = HN.Vary;
    public const string Via = HN.Via;
    public const string Warning = HN.Warning;
    public const string WebSocketSubProtocols = HN.WebSocketSubProtocols;
    public const string WWWAuthenticate = HN.WWWAuthenticate;

    #endregion
}
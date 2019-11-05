// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using MTN = System.Net.Mime.MediaTypeNames;

// ReSharper disable once CheckNamespace
public static class MediaTypeNames
{
    public static class Application
    {
        public const string GraphQl = "application/graphql";

        public const string Json = "application/json";
        public const string JsonApi = "application/vnd.api+json";
        public const string JsonMergePatch = "application/merge-patch+json";
        public const string JsonOpenApi = "application/vnd.oai.openapi+json";
        public const string JsonPatch = "application/json-patch+json";
        public const string JsonSchema = "application/schema+json";

        public const string Xml = "application/xml";

        #region System.Net.Mime.MediaTypeNames

        public const string Octet = MTN.Application.Octet;
        public const string Pdf = MTN.Application.Pdf;
        public const string Rtf = MTN.Application.Rtf;
        public const string Soap = MTN.Application.Soap;
        public const string Zip = MTN.Application.Zip;

        #endregion
    }

    public static class Text
    {
        public const string Markdown = "text/markdown";

        #region System.Net.Mime.MediaTypeNames

        public const string Html = MTN.Text.Html;
        public const string Plain = MTN.Text.Plain;
        public const string RichText = MTN.Text.RichText;
        public const string Xml = MTN.Text.Xml;

        #endregion
    }

    public static class Image
    {
        public const string Markdown = "text/markdown";

        #region System.Net.Mime.MediaTypeNames

        public const string Gif = MTN.Image.Gif;
        public const string Jpeg = MTN.Image.Jpeg;
        public const string Tiff = MTN.Image.Tiff;

        #endregion
    }
}
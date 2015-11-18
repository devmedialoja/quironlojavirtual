using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class StringHelpers
{
    public static string ToSeoUrl(this string url)
    {
        // make the url lowercase
        string encodedUrl = (url ?? "").ToLower();

        // replace & with and
        encodedUrl = Regex.Replace(encodedUrl, @"\&+", "and");

        // remove characters
        encodedUrl = encodedUrl.Replace("'", "");

        // remove invalid characters
        encodedUrl = Regex.Replace(encodedUrl, @"[^a-z0-9]", "-");

        // remove duplicates
        encodedUrl = Regex.Replace(encodedUrl, @"-+", "-");

        // trim leading & trailing characters
        encodedUrl = encodedUrl.Trim('-');

        return encodedUrl;
    }


    public static string UpperCaseFirst(this string title)
    {
        // Check for empty string.
        if (string.IsNullOrEmpty(title))
        {
            return string.Empty;
        }
        // Return char and concat substring.
        return char.ToUpper(title[0]) + title.Substring(1);
    }



}
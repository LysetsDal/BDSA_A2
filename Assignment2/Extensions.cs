namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri uri)
    {
        return uri.Scheme == Uri.UriSchemeHttps;
    }
    

}

using Android.App;
using Android.Content.PM;
using Android.OS;
using Environment = Android.OS.Environment;

namespace MauiApp6;
[Application]
public static class ListPictruresHelper
{
    public static string[] files_help()
    {
        var dir = Environment.GetExternalStoragePublicDirectory(Environment.DirectoryPictures);
        var files = Directory.GetFiles(dir.AbsolutePath, "*");
        return files;
    }
}

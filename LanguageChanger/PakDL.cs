using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace LanguageChanger
{
    internal class PakDL
    {
        public async Task<bool> downloadPak()
        {
            using (var client = new HttpClient())
            {
                var pakdl = Properties.App.Default.selected_lang + "_Text-WindowsClient.pak";
                var sigdl = Properties.App.Default.selected_lang + "_Text-WindowsClient.sig";

                var pakold = Properties.App.Default.local_lang + "_Text-WindowsClient.pak";
                var sigold = Properties.App.Default.local_lang + "_Text-WindowsClient.sig";

                var pakpath = Properties.App.Default.local_gamepath + @"\ShooterGame\Content\Paks\";

                if (File.Exists(pakpath + pakdl)) File.Delete(pakpath + pakdl);
                if (File.Exists(pakpath + sigdl)) File.Delete(pakpath + sigdl);

                await client.DownloadFileTaskAsync(new Uri(Properties.App.Default.baselink + pakdl), pakpath + pakdl);
                await client.DownloadFileTaskAsync(new Uri(Properties.App.Default.baselink + sigdl), pakpath + sigdl);

                if(Properties.App.Default.selected_lang != Properties.App.Default.local_lang)
                {
                    File.Delete(pakpath + pakold);
                    File.Delete(pakpath + sigold);

                    File.Move(pakpath + pakdl, pakpath + pakold);
                    File.Move(pakpath + sigdl, pakpath + sigold);
                }
                return true;
            }
        }
    }
    public static class HttpClientUtils
    {
        public static async Task DownloadFileTaskAsync(this HttpClient client, Uri uri, string FileName)
        {
            using (var s = await client.GetStreamAsync(uri))
            {
                using (var fs = new FileStream(FileName, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs);
                }
            }
        }
    }
}

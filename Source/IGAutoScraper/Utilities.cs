using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace IGAutoScraper
{
    public enum ScrapeType { All, AllPosts, PostImages, PostVideos, AllStory, StoryImages, StoryVideos };

    class Utilities
    {
        public static readonly string COOKIES_FILEPATH = Application.CommonAppDataPath + "\\cookies.ck";
        public static readonly string TIMESTAMPS_FILEPATH = Application.CommonAppDataPath + "\\timestamps.ts";

        public static readonly Dictionary<ScrapeType, string> ScrapeTypeValues = new Dictionary<ScrapeType, string> {
            { ScrapeType.All, "" },
            { ScrapeType.AllPosts, "image video" },
            { ScrapeType.PostImages, "image" },
            { ScrapeType.PostVideos, "video" },
            { ScrapeType.AllStory, "story" },
            { ScrapeType.StoryImages, "story-image" },
            { ScrapeType.StoryVideos, "story-video" }
        };

        public static DirectoryInfo OpenDirectory()
        {
            using (var dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    return new DirectoryInfo(dialog.FileName);
                }
            }

            return null;
        }

        public static void RunScraper(
            string username, 
            ScrapeType scrapeType, 
            string destination, 
            string loginUsername = null, 
            string loginPassword = null)
        {
            string destinationArgument = $"--destination \"{destination}\"";
            string mediaTypeArgument = (scrapeType == ScrapeType.All) ? "" : $"--media-types {ScrapeTypeValues[scrapeType]}";
            string loginDetailsArguments = (string.IsNullOrWhiteSpace(loginUsername) && string.IsNullOrWhiteSpace(loginPassword)) ? "" : $"--login-user {loginUsername} --login-pass {loginPassword}";


            //--cookiejar \"{COOKIES_FILEPATH}\"
            string finalArguments = $" /K instagram-scraper {username} {loginDetailsArguments} {mediaTypeArgument}  " +
                $"{destinationArgument} --interactive --retain-username " +
                "--template \"{username} {mediatype} {day}d{month}m{year}y  {h};{m};{s}\" " +
                $"--latest-stamps \"{TIMESTAMPS_FILEPATH}\"";
            Console.WriteLine(finalArguments);

            ProcessStartInfo startInfo = new ProcessStartInfo {
                FileName = "CMD.EXE",
                Arguments = finalArguments,
                UseShellExecute = true,
                CreateNoWindow = true//,
                //WindowStyle = ProcessWindowStyle.Hidden
            };

            Process process = new Process { StartInfo = startInfo };
            process.Exited += Process_Exited;
            process.Start();
        }

        private static void Process_Exited(object sender, EventArgs e)
        {
            Process process = (Process)sender;
            Console.WriteLine($"Scraping of {process.StartInfo.Arguments.Substring(0, process.StartInfo.Arguments.IndexOf(' '))} finished.");
        }
    }
}

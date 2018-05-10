using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using McMaster.Extensions.CommandLineUtils;

namespace StardewValley.MPSaveEditor.Helpers
{

    public static class CommandHelpers {
        public static int Success = 0;
        public static int Failure = 2;
        public static String GetSaveFile(String path) {
            int userSelection = -1;
            Dictionary<int, String> saveFiles = new Dictionary<int, String>();
            Console.WriteLine("---------");
            Console.WriteLine("Save Files");
            while(!saveFiles.ContainsKey(userSelection)) {
                saveFiles = new Dictionary<int, String>();
                int fileCount = 0;
                foreach(String saveFolder in Directory.GetDirectories(path)) {
                    fileCount++;
                    String saveFileName = Regex.Matches(saveFolder, @"[^\\]*$").First().ToString();
                    String saveFilePath = String.Format("{0}/{1}", saveFolder, saveFileName);
                    saveFiles.Add(fileCount, saveFilePath);
                    Console.WriteLine(String.Format("{0}. {1}", fileCount, saveFileName));
                }
                userSelection = Prompt.GetInt("Select a save file:", 0);
            }

            return saveFiles[userSelection];
        }
    }

}
﻿using Newtonsoft.Json;

namespace YoutubePlaylistDownloader.Objects
{
    [JsonObject]
    public class Settings
    {
        [JsonProperty]
        public string Theme { get; set; }

        [JsonProperty]
        public string Accent { get; set; }

        [JsonProperty]
        public string Language { get; set; }

        [JsonProperty]
        public string SaveDirectory { get; set; }

        [JsonProperty]
        public bool OptionExpanderIsExpanded { get; set; }

        [JsonProperty]
        public bool CheckForSubscriptionUpdates { get; set; }

        [JsonProperty]
        public bool CheckForProgramUpdates { get; set; }


        [JsonConstructor]
        public Settings(string theme, string accent, string language, string saveDirectory, bool optionExpanderIsExpanded, bool checkForSubscriptionUpdates, bool checkForProgramUpdates)
        {
            Theme = theme;
            Accent = accent;
            Language = language;
            SaveDirectory = saveDirectory;
            OptionExpanderIsExpanded = optionExpanderIsExpanded;
            CheckForSubscriptionUpdates = checkForSubscriptionUpdates;
            CheckForProgramUpdates = checkForProgramUpdates;
        }

    }
}

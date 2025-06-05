// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModCinemaStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModCinema";

        /// <summary>
        /// "Watch the video without visual distractions."
        /// </summary>
        public static LocalisableString WatchTheVideoWithoutVisual => new TranslatableString(getKey(@"watch_the_video_without_visual"), @"Watch the video without visual distractions.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
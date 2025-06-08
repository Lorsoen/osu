// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class GroupSectionStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.GroupSection";

        /// <summary>
        /// "Time"
        /// </summary>
        public static LocalisableString Time => new TranslatableString(getKey(@"time"), @"Time");

        /// <summary>
        /// "Use current time"
        /// </summary>
        public static LocalisableString UseCurrentTime => new TranslatableString(getKey(@"use_current_time"), @"Use current time");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ControlPointListStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ControlPointList";

        /// <summary>
        /// "Select closest to current time"
        /// </summary>
        public static LocalisableString SelectClosestToCurrentTime => new TranslatableString(getKey(@"select_closest_to_current_time"), @"Select closest to current time");

        /// <summary>
        /// "+ Clone to current time"
        /// </summary>
        public static LocalisableString CloneToCurrentTime => new TranslatableString(getKey(@"clone_to_current_time"), @"+ Clone to current time");

        /// <summary>
        /// "+ Add at current time"
        /// </summary>
        public static LocalisableString AddAtCurrentTime => new TranslatableString(getKey(@"add_at_current_time"), @"+ Add at current time");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
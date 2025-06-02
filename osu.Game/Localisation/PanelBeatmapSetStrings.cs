// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class PanelBeatmapSetStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.PanelBeatmapSet";

        /// <summary>
        /// "Restore all hidden"
        /// </summary>
        public static LocalisableString RestoreAllHidden => new TranslatableString(getKey(@"restore_all_hidden"), @"Restore all hidden");

        /// <summary>
        /// "Manage..."
        /// </summary>
        public static LocalisableString Manage => new TranslatableString(getKey(@"manage"), @"Manage...");

        /// <summary>
        /// "Delete..."
        /// </summary>
        public static LocalisableString Delete => new TranslatableString(getKey(@"delete"), @"Delete...");

        /// <summary>
        /// "Collections"
        /// </summary>
        public static LocalisableString Collections => new TranslatableString(getKey(@"collections"), @"Collections");

        /// <summary>
        /// "Details..."
        /// </summary>
        public static LocalisableString Details => new TranslatableString(getKey(@"details"), @"Details...");

        /// <summary>
        /// "Expand"
        /// </summary>
        public static LocalisableString Expand => new TranslatableString(getKey(@"expand"), @"Expand");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
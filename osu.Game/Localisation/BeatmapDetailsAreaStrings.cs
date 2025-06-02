// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class BeatmapDetailsAreaStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.BeatmapDetailsArea";

        /// <summary>
        /// "Scope"
        /// </summary>
        public static LocalisableString Scope => new TranslatableString(getKey(@"scope"), @"Scope");

        /// <summary>
        /// "Selected Mods"
        /// </summary>
        public static LocalisableString SelectedMods => new TranslatableString(getKey(@"selected_mods"), @"Selected Mods");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
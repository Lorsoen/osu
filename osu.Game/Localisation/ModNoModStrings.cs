// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModNoModStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModNoMod";

        /// <summary>
        /// "No mods applied."
        /// </summary>
        public static LocalisableString NoModsApplied => new TranslatableString(getKey(@"no_mods_applied"), @"No mods applied.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModHoldOffStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModHoldOff";

        /// <summary>
        /// "Replaces all hold notes with normal notes."
        /// </summary>
        public static LocalisableString ReplacesAllHoldNotesWith => new TranslatableString(getKey(@"replaces_all_hold_notes_with"), @"Replaces all hold notes with normal notes.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

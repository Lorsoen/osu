// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModMirrorStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModMirror";

        /// <summary>
        /// "Notes are flipped horizontally."
        /// </summary>
        public static LocalisableString NotesAreFlippedHorizontally => new TranslatableString(getKey(@"notes_are_flipped_horizontally"), @"Notes are flipped horizontally.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

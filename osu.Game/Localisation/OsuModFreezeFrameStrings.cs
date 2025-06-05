// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModFreezeFrameStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModFreezeFrame";

        /// <summary>
        /// "Burn the notes into your memory."
        /// </summary>
        public static LocalisableString BurnTheNotesIntoYour => new TranslatableString(getKey(@"burn_the_notes_into_your"), @"Burn the notes into your memory.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModClassicStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModClassic";

        /// <summary>
        /// "Feeling nostalgic?"
        /// </summary>
        public static LocalisableString FeelingNostalgic => new TranslatableString(getKey(@"feeling_nostalgic"), @"Feeling nostalgic?");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
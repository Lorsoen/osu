// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModInvertStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModInvert";

        /// <summary>
        /// "Hold the keys. To the beat."
        /// </summary>
        public static LocalisableString HoldTheKeysToThe => new TranslatableString(getKey(@"hold_the_keys_to_the"), @"Hold the keys. To the beat.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

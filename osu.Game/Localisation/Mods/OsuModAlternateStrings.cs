// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModAlternateStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModAlternate";

        /// <summary>
        /// "Don&#39;t use the same key twice in a row!"
        /// </summary>
        public static LocalisableString DontUseTheSameKey => new TranslatableString(getKey(@"dont_use_the_same_key"), @"Don't use the same key twice in a row!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModRandomStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModRandom";

        /// <summary>
        /// "Shuffle around the keys!"
        /// </summary>
        public static LocalisableString ShuffleAroundTheKeys => new TranslatableString(getKey(@"shuffle_around_the_keys"), @"Shuffle around the keys!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

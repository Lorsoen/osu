// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModKey2Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModKey2";

        /// <summary>
        /// "Play with two keys."
        /// </summary>
        public static LocalisableString PlayWithTwoKeys => new TranslatableString(getKey(@"play_with_two_keys"), @"Play with two keys.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

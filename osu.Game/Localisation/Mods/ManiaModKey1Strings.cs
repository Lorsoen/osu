// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModKey1Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModKey1";

        /// <summary>
        /// "Play with one key."
        /// </summary>
        public static LocalisableString PlayWithOneKey => new TranslatableString(getKey(@"play_with_one_key"), @"Play with one key.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

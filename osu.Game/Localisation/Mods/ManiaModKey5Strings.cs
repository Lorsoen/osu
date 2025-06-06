// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModKey5Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModKey5";

        /// <summary>
        /// "Play with five keys."
        /// </summary>
        public static LocalisableString PlayWithFiveKeys => new TranslatableString(getKey(@"play_with_five_keys"), @"Play with five keys.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

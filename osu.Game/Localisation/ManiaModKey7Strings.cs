// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ManiaModKey7Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ManiaModKey7";

        /// <summary>
        /// "Play with seven keys."
        /// </summary>
        public static LocalisableString PlayWithSevenKeys => new TranslatableString(getKey(@"play_with_seven_keys"), @"Play with seven keys.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
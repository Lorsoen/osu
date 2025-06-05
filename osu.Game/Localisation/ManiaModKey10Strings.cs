// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ManiaModKey10Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ManiaModKey10";

        /// <summary>
        /// "Play with ten keys."
        /// </summary>
        public static LocalisableString PlayWithTenKeys => new TranslatableString(getKey(@"play_with_ten_keys"), @"Play with ten keys.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
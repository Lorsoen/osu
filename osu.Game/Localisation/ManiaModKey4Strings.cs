// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ManiaModKey4Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ManiaModKey4";

        /// <summary>
        /// "Play with four keys."
        /// </summary>
        public static LocalisableString PlayWithFourKeys => new TranslatableString(getKey(@"play_with_four_keys"), @"Play with four keys.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
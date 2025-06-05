// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ManiaModKey8Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ManiaModKey8";

        /// <summary>
        /// "Play with eight keys."
        /// </summary>
        public static LocalisableString PlayWithEightKeys => new TranslatableString(getKey(@"play_with_eight_keys"), @"Play with eight keys.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
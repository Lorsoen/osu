// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ManiaModKey6Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ManiaModKey6";

        /// <summary>
        /// "Play with six keys."
        /// </summary>
        public static LocalisableString PlayWithSixKeys => new TranslatableString(getKey(@"play_with_six_keys"), @"Play with six keys.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModKey9Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModKey9";

        /// <summary>
        /// "Play with nine keys."
        /// </summary>
        public static LocalisableString PlayWithNineKeys => new TranslatableString(getKey(@"play_with_nine_keys"), @"Play with nine keys.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

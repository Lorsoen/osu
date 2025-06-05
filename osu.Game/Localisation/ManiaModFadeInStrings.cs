// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ManiaModFadeInStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ManiaModFadeIn";

        /// <summary>
        /// "Keys appear out of nowhere!"
        /// </summary>
        public static LocalisableString KeysAppearOutOfNowhere => new TranslatableString(getKey(@"keys_appear_out_of_nowhere"), @"Keys appear out of nowhere!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModRelaxStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModRelax";

        /// <summary>
        /// "You don&#39;t need to click. Give your clicking/tapping fingers a break from the heat of things."
        /// </summary>
        public static LocalisableString YouDontNeedToClick => new TranslatableString(getKey(@"you_dont_need_to_click"), @"You don't need to click. Give your clicking/tapping fingers a break from the heat of things.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

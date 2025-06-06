// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModEasyStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModEasy";

        /// <summary>
        /// "More forgiving HP drain, less accuracy required, and extra lives!"
        /// </summary>
        public static LocalisableString MoreForgivingHPDrainLess => new TranslatableString(getKey(@"more_forgiving_hpdrain_less"), @"More forgiving HP drain, less accuracy required, and extra lives!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

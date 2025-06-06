// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModWiggleStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModWiggle";

        /// <summary>
        /// "They just won&#39;t stay still..."
        /// </summary>
        public static LocalisableString TheyJustWontStayStill => new TranslatableString(getKey(@"they_just_wont_stay_still"), @"They just won't stay still...");

        /// <summary>
        /// "Strength"
        /// </summary>
        public static LocalisableString Strength => new TranslatableString(getKey(@"strength"), @"Strength");

        /// <summary>
        /// "Multiplier applied to the wiggling strength."
        /// </summary>
        public static LocalisableString MultiplierAppliedToTheWiggling => new TranslatableString(getKey(@"multiplier_applied_to_the_wiggling"), @"Multiplier applied to the wiggling strength.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

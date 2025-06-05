// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModDaycoreStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModDaycore";

        /// <summary>
        /// "Whoaaaaa..."
        /// </summary>
        public static LocalisableString Whoaaaaa => new TranslatableString(getKey(@"whoaaaaa"), @"Whoaaaaa...");

        /// <summary>
        /// "Speed decrease"
        /// </summary>
        public static LocalisableString SpeedDecrease => new TranslatableString(getKey(@"speed_decrease"), @"Speed decrease");

        /// <summary>
        /// "The actual decrease to apply"
        /// </summary>
        public static LocalisableString TheActualDecreaseToApply => new TranslatableString(getKey(@"the_actual_decrease_to_apply"), @"The actual decrease to apply");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
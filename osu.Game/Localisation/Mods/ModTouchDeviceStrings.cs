// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModTouchDeviceStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModTouchDevice";

        /// <summary>
        /// "Automatically applied to plays on devices with a touchscreen."
        /// </summary>
        public static LocalisableString AutomaticallyAppliedToPlaysOn => new TranslatableString(getKey(@"automatically_applied_to_plays_on"), @"Automatically applied to plays on devices with a touchscreen.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class HiddenComboSliderStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.HiddenComboSlider";

        /// <summary>
        /// "always hidden"
        /// </summary>
        public static LocalisableString AlwaysHidden => new TranslatableString(getKey(@"always_hidden"), @"always hidden");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
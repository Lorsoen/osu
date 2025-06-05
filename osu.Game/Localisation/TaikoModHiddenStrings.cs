// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class TaikoModHiddenStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.TaikoModHidden";

        /// <summary>
        /// "Beats fade out before you hit them!"
        /// </summary>
        public static LocalisableString BeatsFadeOutBeforeYou => new TranslatableString(getKey(@"beats_fade_out_before_you"), @"Beats fade out before you hit them!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
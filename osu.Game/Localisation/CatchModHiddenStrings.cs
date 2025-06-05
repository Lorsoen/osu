// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class CatchModHiddenStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.CatchModHidden";

        /// <summary>
        /// "Play with fading fruits."
        /// </summary>
        public static LocalisableString PlayWithFadingFruits => new TranslatableString(getKey(@"play_with_fading_fruits"), @"Play with fading fruits.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
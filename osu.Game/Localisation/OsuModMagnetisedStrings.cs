// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModMagnetisedStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModMagnetised";

        /// <summary>
        /// "No need to chase the circles – your cursor is a magnet!"
        /// </summary>
        public static LocalisableString NoNeedToChaseThe => new TranslatableString(getKey(@"no_need_to_chase_the"), @"No need to chase the circles – your cursor is a magnet!");

        /// <summary>
        /// "Attraction strength"
        /// </summary>
        public static LocalisableString AttractionStrength => new TranslatableString(getKey(@"attraction_strength"), @"Attraction strength");

        /// <summary>
        /// "How strong the pull is."
        /// </summary>
        public static LocalisableString HowStrongThePullIs => new TranslatableString(getKey(@"how_strong_the_pull_is"), @"How strong the pull is.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
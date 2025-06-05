// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class CatchModMirrorStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.CatchModMirror";

        /// <summary>
        /// "Fruits are flipped horizontally."
        /// </summary>
        public static LocalisableString FruitsAreFlippedHorizontally => new TranslatableString(getKey(@"fruits_are_flipped_horizontally"), @"Fruits are flipped horizontally.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModMirrorStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModMirror";

        /// <summary>
        /// "Flip objects on the chosen axes."
        /// </summary>
        public static LocalisableString FlipObjectsOnTheChosen => new TranslatableString(getKey(@"flip_objects_on_the_chosen"), @"Flip objects on the chosen axes.");

        /// <summary>
        /// "Flipped axes"
        /// </summary>
        public static LocalisableString FlippedAxes => new TranslatableString(getKey(@"flipped_axes"), @"Flipped axes");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
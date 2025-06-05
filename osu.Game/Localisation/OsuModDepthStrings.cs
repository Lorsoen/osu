// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModDepthStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModDepth";

        /// <summary>
        /// "3D. Almost."
        /// </summary>
        public static LocalisableString DAlmost => new TranslatableString(getKey(@"dalmost"), @"3D. Almost.");

        /// <summary>
        /// "Maximum depth"
        /// </summary>
        public static LocalisableString MaximumDepth => new TranslatableString(getKey(@"maximum_depth"), @"Maximum depth");

        /// <summary>
        /// "How far away objects appear."
        /// </summary>
        public static LocalisableString HowFarAwayObjectsAppear => new TranslatableString(getKey(@"how_far_away_objects_appear"), @"How far away objects appear.");

        /// <summary>
        /// "Show Approach Circles"
        /// </summary>
        public static LocalisableString ShowApproachCircles => new TranslatableString(getKey(@"show_approach_circles"), @"Show Approach Circles");

        /// <summary>
        /// "Whether approach circles should be visible."
        /// </summary>
        public static LocalisableString WhetherApproachCirclesShouldBe => new TranslatableString(getKey(@"whether_approach_circles_should_be"), @"Whether approach circles should be visible.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
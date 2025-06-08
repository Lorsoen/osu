// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class FreehandSliderToolboxGroupStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.FreehandSliderToolboxGroup";

        /// <summary>
        /// "slider"
        /// </summary>
        public static LocalisableString Slider => new TranslatableString(getKey(@"slider"), @"slider");

        /// <summary>
        /// "C. P. S.: {0}"
        /// </summary>
        public static LocalisableString CPS(int arg0) => new TranslatableString(getKey(@"cps"), @"C. P. S.: {0}", arg0);

        /// <summary>
        /// "Control Point Spacing: {0}"
        /// </summary>
        public static LocalisableString ControlPointSpacing(int arg0) => new TranslatableString(getKey(@"control_point_spacing"), @"Control Point Spacing: {0}", arg0);

        /// <summary>
        /// "C. T.: {0}"
        /// </summary>
        public static LocalisableString CT(int arg0) => new TranslatableString(getKey(@"ct"), @"C. T.: {0}", arg0);

        /// <summary>
        /// "Corner Threshold: {0}"
        /// </summary>
        public static LocalisableString CornerThreshold(int arg0) => new TranslatableString(getKey(@"corner_threshold"), @"Corner Threshold: {0}", arg0);

        /// <summary>
        /// "P. C. T.: {0}"
        /// </summary>
        public static LocalisableString PCT(int arg0) => new TranslatableString(getKey(@"pct"), @"P. C. T.: {0}", arg0);

        /// <summary>
        /// "Perfect Curve Threshold: {0}"
        /// </summary>
        public static LocalisableString PerfectCurveThreshold(int arg0) => new TranslatableString(getKey(@"perfect_curve_threshold"), @"Perfect Curve Threshold: {0}", arg0);

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class HitObjectInspectorStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.HitObjectInspector";

        /// <summary>
        /// "No selection"
        /// </summary>
        public static LocalisableString NoSelection => new TranslatableString(getKey(@"no_selection"), @"No selection");

        /// <summary>
        /// "Type"
        /// </summary>
        public static LocalisableString Type => new TranslatableString(getKey(@"type"), @"Type");

        /// <summary>
        /// "Time"
        /// </summary>
        public static LocalisableString Time => new TranslatableString(getKey(@"time"), @"Time");

        /// <summary>
        /// "Position"
        /// </summary>
        public static LocalisableString Position => new TranslatableString(getKey(@"position"), @"Position");

        /// <summary>
        /// "Distance"
        /// </summary>
        public static LocalisableString Distance => new TranslatableString(getKey(@"distance"), @"Distance");

        /// <summary>
        /// "Slider Velocity"
        /// </summary>
        public static LocalisableString SliderVelocity => new TranslatableString(getKey(@"slider_velocity"), @"Slider Velocity");

        /// <summary>
        /// "Repeats"
        /// </summary>
        public static LocalisableString Repeats => new TranslatableString(getKey(@"repeats"), @"Repeats");

        /// <summary>
        /// "End Time"
        /// </summary>
        public static LocalisableString EndTime => new TranslatableString(getKey(@"end_time"), @"End Time");

        /// <summary>
        /// "Duration"
        /// </summary>
        public static LocalisableString Duration => new TranslatableString(getKey(@"duration"), @"Duration");

        /// <summary>
        /// "Selected Objects"
        /// </summary>
        public static LocalisableString SelectedObjects => new TranslatableString(getKey(@"selected_objects"), @"Selected Objects");

        /// <summary>
        /// "Start Time"
        /// </summary>
        public static LocalisableString StartTime => new TranslatableString(getKey(@"start_time"), @"Start Time");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
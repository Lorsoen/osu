// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModObjectScaleTweenStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModObjectScaleTween";

        /// <summary>
        /// "Starting Size"
        /// </summary>
        public static LocalisableString StartingSize => new TranslatableString(getKey(@"starting_size"), @"Starting Size");

        /// <summary>
        /// "The initial size multiplier applied to all objects."
        /// </summary>
        public static LocalisableString TheInitialSizeMultiplierApplied => new TranslatableString(getKey(@"the_initial_size_multiplier_applied"), @"The initial size multiplier applied to all objects.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

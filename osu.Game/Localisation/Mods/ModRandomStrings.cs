// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModRandomStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModRandom";

        /// <summary>
        /// "Seed"
        /// </summary>
        public static LocalisableString Seed => new TranslatableString(getKey(@"seed"), @"Seed");

        /// <summary>
        /// "Use a custom seed instead of a random one"
        /// </summary>
        public static LocalisableString UseACustomSeedInstead => new TranslatableString(getKey(@"use_acustom_seed_instead"), @"Use a custom seed instead of a random one");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ManiaModDualStagesStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ManiaModDualStages";

        /// <summary>
        /// "Double the stages, double the fun!"
        /// </summary>
        public static LocalisableString DoubleTheStagesDoubleThe => new TranslatableString(getKey(@"double_the_stages_double_the"), @"Double the stages, double the fun!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

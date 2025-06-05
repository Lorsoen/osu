// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class CatchModEasyStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.CatchModEasy";

        /// <summary>
        /// "Larger fruits, more forgiving HP drain, less accuracy required, and extra lives!"
        /// </summary>
        public static LocalisableString LargerFruitsMoreForgivingHP => new TranslatableString(getKey(@"larger_fruits_more_forgiving_hp"), @"Larger fruits, more forgiving HP drain, less accuracy required, and extra lives!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
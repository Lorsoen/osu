// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModSuddenDeathStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModSuddenDeath";

        /// <summary>
        /// "Miss and fail."
        /// </summary>
        public static LocalisableString MissAndFail => new TranslatableString(getKey(@"miss_and_fail"), @"Miss and fail.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
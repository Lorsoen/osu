// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModNoFailStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModNoFail";

        /// <summary>
        /// "You can&#39;t fail, no matter what."
        /// </summary>
        public static LocalisableString NoFailDescription => new TranslatableString(getKey(@"you_cant_fail_no_matter"), @"You can't fail, no matter what.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class TaikoModEasyStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.TaikoModEasy";

        /// <summary>
        /// "Beats move slower, and less accuracy required!"
        /// </summary>
        public static LocalisableString BeatsMoveSlowerAndLess => new TranslatableString(getKey(@"beats_move_slower_and_less"), @"Beats move slower, and less accuracy required!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
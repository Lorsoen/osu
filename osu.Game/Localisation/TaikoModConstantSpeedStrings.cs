// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class TaikoModConstantSpeedStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.TaikoModConstantSpeed";

        /// <summary>
        /// "No more tricky speed changes!"
        /// </summary>
        public static LocalisableString NoMoreTrickySpeedChanges => new TranslatableString(getKey(@"no_more_tricky_speed_changes"), @"No more tricky speed changes!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
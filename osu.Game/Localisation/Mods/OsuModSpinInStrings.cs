// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModSpinInStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModSpinIn";

        /// <summary>
        /// "Circles spin in. No approach circles."
        /// </summary>
        public static LocalisableString CirclesSpinInNoApproach => new TranslatableString(getKey(@"circles_spin_in_no_approach"), @"Circles spin in. No approach circles.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

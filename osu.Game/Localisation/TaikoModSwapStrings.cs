// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class TaikoModSwapStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.TaikoModSwap";

        /// <summary>
        /// "Dons become kats, kats become dons"
        /// </summary>
        public static LocalisableString DonsBecomeKatsKatsBecome => new TranslatableString(getKey(@"dons_become_kats_kats_become"), @"Dons become kats, kats become dons");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
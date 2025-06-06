// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class TaikoModSingleTapStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.TaikoModSingleTap";

        /// <summary>
        /// "One key for dons, one key for kats."
        /// </summary>
        public static LocalisableString OneKeyForDonsOne => new TranslatableString(getKey(@"one_key_for_dons_one"), @"One key for dons, one key for kats.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

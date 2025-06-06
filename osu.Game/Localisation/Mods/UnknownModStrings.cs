// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class UnknownModStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.UnknownMod";

        /// <summary>
        /// "This mod could not be resolved by the game."
        /// </summary>
        public static LocalisableString ThisModCouldNotBe => new TranslatableString(getKey(@"this_mod_could_not_be"), @"This mod could not be resolved by the game.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

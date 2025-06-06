// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModSingleTapStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModSingleTap";

        /// <summary>
        /// "You must only use one key!"
        /// </summary>
        public static LocalisableString YouMustOnlyUseOne => new TranslatableString(getKey(@"you_must_only_use_one"), @"You must only use one key!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModWindUpStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModWindUp";

        /// <summary>
        /// "Can you keep up?"
        /// </summary>
        public static LocalisableString CanYouKeepUp => new TranslatableString(getKey(@"can_you_keep_up"), @"Can you keep up?");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

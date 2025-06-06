// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModPerfectStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModPerfect";

        /// <summary>
        /// "SS or quit."
        /// </summary>
        public static LocalisableString SSOrQuit => new TranslatableString(getKey(@"ssor_quit"), @"SS or quit.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

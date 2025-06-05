// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModWindDownStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModWindDown";

        /// <summary>
        /// "Sloooow doooown..."
        /// </summary>
        public static LocalisableString SloooowDoooown => new TranslatableString(getKey(@"sloooow_doooown"), @"Sloooow doooown...");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModTransformStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModTransform";

        /// <summary>
        /// "Everything rotates. EVERYTHING."
        /// </summary>
        public static LocalisableString EverythingRotatesEVERYTHING => new TranslatableString(getKey(@"everything_rotates_everything"), @"Everything rotates. EVERYTHING.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

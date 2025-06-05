// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModDeflateStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModDeflate";

        /// <summary>
        /// "Hit them at the right size!"
        /// </summary>
        public static LocalisableString HitThemAtTheRight => new TranslatableString(getKey(@"hit_them_at_the_right"), @"Hit them at the right size!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
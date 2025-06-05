// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class TaikoModRandomStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.TaikoModRandom";

        /// <summary>
        /// "Shuffle around the colours!"
        /// </summary>
        public static LocalisableString ShuffleAroundTheColours => new TranslatableString(getKey(@"shuffle_around_the_colours"), @"Shuffle around the colours!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
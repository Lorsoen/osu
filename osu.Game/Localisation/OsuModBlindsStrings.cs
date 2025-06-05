// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModBlindsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModBlinds";

        /// <summary>
        /// "Play with blinds on your screen."
        /// </summary>
        public static LocalisableString PlayWithBlindsOnYour => new TranslatableString(getKey(@"play_with_blinds_on_your"), @"Play with blinds on your screen.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModBubblesStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModBubbles";

        /// <summary>
        /// "Don&#39;t let their popping distract you!"
        /// </summary>
        public static LocalisableString DontLetTheirPoppingDistract => new TranslatableString(getKey(@"dont_let_their_popping_distract"), @"Don't let their popping distract you!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
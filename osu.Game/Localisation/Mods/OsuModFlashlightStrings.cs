// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModFlashlightStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModFlashlight";

        /// <summary>
        /// "Follow delay"
        /// </summary>
        public static LocalisableString FollowDelay => new TranslatableString(getKey(@"follow_delay"), @"Follow delay");

        /// <summary>
        /// "Milliseconds until the flashlight reaches the cursor"
        /// </summary>
        public static LocalisableString MillisecondsUntilTheFlashlightReaches => new TranslatableString(getKey(@"milliseconds_until_the_flashlight_reaches"), @"Milliseconds until the flashlight reaches the cursor");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

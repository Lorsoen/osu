// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModRandomStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModRandom";

        /// <summary>
        /// "It never gets boring!"
        /// </summary>
        public static LocalisableString ItNeverGetsBoring => new TranslatableString(getKey(@"it_never_gets_boring"), @"It never gets boring!");

        /// <summary>
        /// "Angle sharpness"
        /// </summary>
        public static LocalisableString AngleSharpness => new TranslatableString(getKey(@"angle_sharpness"), @"Angle sharpness");

        /// <summary>
        /// "How sharp angles should be"
        /// </summary>
        public static LocalisableString HowSharpAnglesShouldBe => new TranslatableString(getKey(@"how_sharp_angles_should_be"), @"How sharp angles should be");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

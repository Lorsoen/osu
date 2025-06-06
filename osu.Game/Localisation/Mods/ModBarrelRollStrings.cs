// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModBarrelRollStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModBarrelRoll";

        /// <summary>
        /// "Roll speed"
        /// </summary>
        public static LocalisableString RollSpeed => new TranslatableString(getKey(@"roll_speed"), @"Roll speed");

        /// <summary>
        /// "Rotations per minute"
        /// </summary>
        public static LocalisableString RotationsPerMinute => new TranslatableString(getKey(@"rotations_per_minute"), @"Rotations per minute");

        /// <summary>
        /// "Direction"
        /// </summary>
        public static LocalisableString Direction => new TranslatableString(getKey(@"direction"), @"Direction");

        /// <summary>
        /// "The direction of rotation"
        /// </summary>
        public static LocalisableString TheDirectionOfRotation => new TranslatableString(getKey(@"the_direction_of_rotation"), @"The direction of rotation");

        /// <summary>
        /// "The whole playfield is on a wheel!"
        /// </summary>
        public static LocalisableString TheWholePlayfieldIsOn => new TranslatableString(getKey(@"the_whole_playfield_is_on"), @"The whole playfield is on a wheel!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

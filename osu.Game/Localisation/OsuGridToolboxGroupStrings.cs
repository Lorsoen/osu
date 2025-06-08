// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuGridToolboxGroupStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuGridToolboxGroup";

        /// <summary>
        /// "Square"
        /// </summary>
        public static LocalisableString Square => new TranslatableString(getKey(@"square"), @"Square");

        /// <summary>
        /// "Triangle"
        /// </summary>
        public static LocalisableString Triangle => new TranslatableString(getKey(@"triangle"), @"Triangle");

        /// <summary>
        /// "Square"
        /// </summary>
        public static LocalisableString Circle => new TranslatableString(getKey(@"circle"), @"Square");

        /// <summary>
        /// "X: {0}"
        /// </summary>
        public static LocalisableString X(float arg0) => new TranslatableString(getKey(@"x"), @"X: {0}", arg0);

        /// <summary>
        /// "X Offset: {0}"
        /// </summary>
        public static LocalisableString XOffset(float arg0) => new TranslatableString(getKey(@"xoffset"), @"X Offset: {0}", arg0);

        /// <summary>
        /// "Y: {0}"
        /// </summary>
        public static LocalisableString Y(float arg0) => new TranslatableString(getKey(@"y"), @"Y: {0}", arg0);

        /// <summary>
        /// "Y Offset: {0}"
        /// </summary>
        public static LocalisableString YOffset(float arg0) => new TranslatableString(getKey(@"yoffset"), @"Y Offset: {0}", arg0);

        /// <summary>
        /// "S: {0}"
        /// </summary>
        public static LocalisableString S(float arg0) => new TranslatableString(getKey(@"s"), @"S: {0}", arg0);

        /// <summary>
        /// "Spacing: {0}"
        /// </summary>
        public static LocalisableString Spacing(float arg0) => new TranslatableString(getKey(@"spacing"), @"Spacing: {0}", arg0);

        /// <summary>
        /// "R: {0}"
        /// </summary>
        public static LocalisableString R(float arg0) => new TranslatableString(getKey(@"r"), @"R: {0}", arg0);

        /// <summary>
        /// "Rotation: {0}"
        /// </summary>
        public static LocalisableString Rotation(float arg0) => new TranslatableString(getKey(@"rotation"), @"Rotation: {0}", arg0);


        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

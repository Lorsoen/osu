// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class BeatmapMetadataWedgeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.BeatmapMetadataWedge";

        /// <summary>
        /// "Creator"
        /// </summary>
        public static LocalisableString Creator => new TranslatableString(getKey(@"creator"), @"Creator");

        /// <summary>
        /// "Genre"
        /// </summary>
        public static LocalisableString Genre => new TranslatableString(getKey(@"genre"), @"Genre");

        /// <summary>
        /// "Source"
        /// </summary>
        public static LocalisableString Source => new TranslatableString(getKey(@"source"), @"Source");

        /// <summary>
        /// "Language"
        /// </summary>
        public static LocalisableString Language => new TranslatableString(getKey(@"language"), @"Language");

        /// <summary>
        /// "Ranked"
        /// </summary>
        public static LocalisableString Ranked => new TranslatableString(getKey(@"ranked"), @"Ranked");

        /// <summary>
        /// "User Tags"
        /// </summary>
        public static LocalisableString UserTags => new TranslatableString(getKey(@"user_tags"), @"User Tags");

        /// <summary>
        /// "Mapper Tags"
        /// </summary>
        public static LocalisableString MapperTags => new TranslatableString(getKey(@"mapper_tags"), @"Mapper Tags");

        /// <summary>
        /// "Submitted"
        /// </summary>
        public static LocalisableString Submitted => new TranslatableString(getKey(@"submitted"), @"Submitted");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
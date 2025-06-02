// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class BeatmapTitleWedgeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.BeatmapTitleWedge";

        /// <summary>
        /// " mapped by "
        /// </summary>
        public static LocalisableString MappedBy => new TranslatableString(getKey(@"mapped_by"), @" mapped by ");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
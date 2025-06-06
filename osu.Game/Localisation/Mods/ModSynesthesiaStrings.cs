// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModSynesthesiaStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModSynesthesia";

        /// <summary>
        /// "Colours hit objects based on the rhythm."
        /// </summary>
        public static LocalisableString ColoursHitObjectsBasedOn => new TranslatableString(getKey(@"colours_hit_objects_based_on"), @"Colours hit objects based on the rhythm.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

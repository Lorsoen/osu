// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ManiaModCoverStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ManiaModCover";

        /// <summary>
        /// "Decrease the playfield&#39;s viewing area."
        /// </summary>
        public static LocalisableString DecreaseThePlayfieldsViewingArea => new TranslatableString(getKey(@"decrease_the_playfields_viewing_area"), @"Decrease the playfield's viewing area.");

        /// <summary>
        /// "Coverage"
        /// </summary>
        public static LocalisableString Coverage => new TranslatableString(getKey(@"coverage"), @"Coverage");

        /// <summary>
        /// "The proportion of playfield height that notes will be hidden for."
        /// </summary>
        public static LocalisableString TheProportionOfPlayfieldHeight => new TranslatableString(getKey(@"the_proportion_of_playfield_height"), @"The proportion of playfield height that notes will be hidden for.");

        /// <summary>
        /// "Direction"
        /// </summary>
        public static LocalisableString Direction => new TranslatableString(getKey(@"direction"), @"Direction");

        /// <summary>
        /// "The direction on which the cover is applied"
        /// </summary>
        public static LocalisableString TheDirectionOnWhichThe => new TranslatableString(getKey(@"the_direction_on_which_the"), @"The direction on which the cover is applied");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
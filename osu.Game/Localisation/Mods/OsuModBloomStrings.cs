// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModBloomStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModBloom";

        /// <summary>
        /// "The cursor blooms into.. a larger cursor!"
        /// </summary>
        public static LocalisableString TheCursorBloomsIntoA => new TranslatableString(getKey(@"the_cursor_blooms_into_a"), @"The cursor blooms into.. a larger cursor!");

        /// <summary>
        /// "Max size at combo"
        /// </summary>
        public static LocalisableString MaxSizeAtCombo => new TranslatableString(getKey(@"max_size_at_combo"), @"Max size at combo");

        /// <summary>
        /// "The combo count at which the cursor reaches its maximum size"
        /// </summary>
        public static LocalisableString TheComboCountAtWhich => new TranslatableString(getKey(@"the_combo_count_at_which"), @"The combo count at which the cursor reaches its maximum size");

        /// <summary>
        /// "Final size multiplier"
        /// </summary>
        public static LocalisableString FinalSizeMultiplier => new TranslatableString(getKey(@"final_size_multiplier"), @"Final size multiplier");

        /// <summary>
        /// "The multiplier applied to cursor size when combo reaches maximum"
        /// </summary>
        public static LocalisableString TheMultiplierAppliedToCursor => new TranslatableString(getKey(@"the_multiplier_applied_to_cursor"), @"The multiplier applied to cursor size when combo reaches maximum");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

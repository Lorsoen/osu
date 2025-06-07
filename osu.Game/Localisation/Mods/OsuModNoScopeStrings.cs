// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModNoScopeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModNoScope";

        /// <summary>
        /// "Where&#39;s the cursor?"
        /// </summary>
        public static LocalisableString WheresTheCursor => new TranslatableString(getKey(@"wheres_the_cursor"), @"Where's the cursor?");

        /// <summary>
        /// "Hidden at combo"
        /// </summary>
        public static LocalisableString HiddenAtCombo => new TranslatableString(getKey(@"hidden_at_combo"), @"Hidden at combo");

        /// <summary>
        /// "The combo count at which the cursor becomes completely hidden"
        /// </summary>
        public static LocalisableString TheComboCountAtWhich => new TranslatableString(getKey(@"the_combo_count_at_which"), @"The combo count at which the cursor becomes completely hidden");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

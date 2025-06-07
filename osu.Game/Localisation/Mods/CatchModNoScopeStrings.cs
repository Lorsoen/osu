// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class CatchModNoScopeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.CatchModNoScope";

        /// <summary>
        /// "Where&#39;s the catcher?"
        /// </summary>
        public static LocalisableString WheresTheCatcher => new TranslatableString(getKey(@"wheres_the_catcher"), @"Where's the catcher?");

        /// <summary>
        /// "Hidden at combo"
        /// </summary>
        public static LocalisableString HiddenAtCombo => new TranslatableString(getKey(@"hidden_at_combo"), @"Hidden at combo");

        /// <summary>
        /// "The combo count at which the catcher becomes completely hidden"
        /// </summary>
        public static LocalisableString TheComboCountAtWhich => new TranslatableString(getKey(@"the_combo_count_at_which"), @"The combo count at which the catcher becomes completely hidden");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

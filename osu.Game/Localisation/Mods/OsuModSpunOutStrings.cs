// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModSpunOutStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModSpunOut";

        /// <summary>
        /// "Spinners will be automatically completed."
        /// </summary>
        public static LocalisableString SpinnersWillBeAutomaticallyCompleted => new TranslatableString(getKey(@"spinners_will_be_automatically_completed"), @"Spinners will be automatically completed.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class CatchModNoScopeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.CatchModNoScope";

        /// <summary>
        /// "Where&#39;s the catcher?"
        /// </summary>
        public static LocalisableString WheresTheCatcher => new TranslatableString(getKey(@"wheres_the_catcher"), @"Where's the catcher?");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
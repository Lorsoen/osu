// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class TaikoModRelaxStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.TaikoModRelax";

        /// <summary>
        /// "No need to remember which key is correct anymore!"
        /// </summary>
        public static LocalisableString NoNeedToRememberWhich => new TranslatableString(getKey(@"no_need_to_remember_which"), @"No need to remember which key is correct anymore!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
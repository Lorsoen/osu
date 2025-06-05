// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModFailConditionStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModFailCondition";

        /// <summary>
        /// "Restart on fail"
        /// </summary>
        public static LocalisableString RestartOnFail => new TranslatableString(getKey(@"restart_on_fail"), @"Restart on fail");

        /// <summary>
        /// "Automatically restarts when failed."
        /// </summary>
        public static LocalisableString AutomaticallyRestartsWhenFailed => new TranslatableString(getKey(@"automatically_restarts_when_failed"), @"Automatically restarts when failed.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
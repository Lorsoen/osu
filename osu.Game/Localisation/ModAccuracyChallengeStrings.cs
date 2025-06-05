// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModAccuracyChallengeStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModAccuracyChallenge";

        /// <summary>
        /// "Fail if your accuracy drops too low!"
        /// </summary>
        public static LocalisableString FailIfYourAccuracyDrops => new TranslatableString(getKey(@"fail_if_your_accuracy_drops"), @"Fail if your accuracy drops too low!");

        /// <summary>
        /// "Minimum accuracy"
        /// </summary>
        public static LocalisableString MinimumAccuracy => new TranslatableString(getKey(@"minimum_accuracy"), @"Minimum accuracy");

        /// <summary>
        /// "Accuracy mode"
        /// </summary>
        public static LocalisableString AccuracyMode => new TranslatableString(getKey(@"accuracy_mode"), @"Accuracy mode");

        /// <summary>
        /// "Restart on fail"
        /// </summary>
        public static LocalisableString RestartOnFail => new TranslatableString(getKey(@"restart_on_fail"), @"Restart on fail");

        /// <summary>
        /// "Trigger a failure if your accuracy goes below this value."
        /// </summary>
        public static LocalisableString TriggerAFailureIfYour => new TranslatableString(getKey(@"trigger_afailure_if_your"), @"Trigger a failure if your accuracy goes below this value.");

        /// <summary>
        /// "The mode of accuracy that will trigger failure."
        /// </summary>
        public static LocalisableString TheModeOfAccuracyThat => new TranslatableString(getKey(@"the_mode_of_accuracy_that"), @"The mode of accuracy that will trigger failure.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
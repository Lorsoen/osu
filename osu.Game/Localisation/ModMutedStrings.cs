// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModMutedStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModMuted";

        /// <summary>
        /// "Can you still feel the rhythm without music?"
        /// </summary>
        public static LocalisableString CanYouStillFeelThe => new TranslatableString(getKey(@"can_you_still_feel_the"), @"Can you still feel the rhythm without music?");

        /// <summary>
        /// "Start muted"
        /// </summary>
        public static LocalisableString StartMuted => new TranslatableString(getKey(@"start_muted"), @"Start muted");

        /// <summary>
        /// "Increase volume as combo builds."
        /// </summary>
        public static LocalisableString IncreaseVolumeAsComboBuilds => new TranslatableString(getKey(@"increase_volume_as_combo_builds"), @"Increase volume as combo builds.");

        /// <summary>
        /// "Enable metronome"
        /// </summary>
        public static LocalisableString EnableMetronome => new TranslatableString(getKey(@"enable_metronome"), @"Enable metronome");

        /// <summary>
        /// "Add a metronome beat to help you keep track of the rhythm."
        /// </summary>
        public static LocalisableString AddAMetronomeBeatTo => new TranslatableString(getKey(@"add_ametronome_beat_to"), @"Add a metronome beat to help you keep track of the rhythm.");

        /// <summary>
        /// "Final volume at combo"
        /// </summary>
        public static LocalisableString FinalVolumeAtCombo => new TranslatableString(getKey(@"final_volume_at_combo"), @"Final volume at combo");

        /// <summary>
        /// "The combo count at which point the track reaches its final volume."
        /// </summary>
        public static LocalisableString TheComboCountAtWhich => new TranslatableString(getKey(@"the_combo_count_at_which"), @"The combo count at which point the track reaches its final volume.");

        /// <summary>
        /// "Mute hit sounds"
        /// </summary>
        public static LocalisableString MuteHitSounds => new TranslatableString(getKey(@"mute_hit_sounds"), @"Mute hit sounds");

        /// <summary>
        /// "Hit sounds are also muted alongside the track."
        /// </summary>
        public static LocalisableString HitSoundsAreAlsoMuted => new TranslatableString(getKey(@"hit_sounds_are_also_muted"), @"Hit sounds are also muted alongside the track.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
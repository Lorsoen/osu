// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModDescriptionStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModFlashlight";

        /// <summary>
        /// "Restricted view area."
        /// </summary>
        public static LocalisableString FlashlightDescription => new TranslatableString(getKey(@"restricted_view_area"), @"Restricted view area.");

        /// <summary>
        /// "Flashlight size"
        /// </summary>
        public static LocalisableString FlashlightSize => new TranslatableString(getKey(@"flashlight_size"), @"Flashlight size");

        /// <summary>
        /// "Multiplier applied to the default flashlight size."
        /// </summary>
        public static LocalisableString FlashlightSizeDescription => new TranslatableString(getKey(@"multiplier_applied_to_the_default"), @"Multiplier applied to the default flashlight size.");

        /// <summary>
        /// "Change size based on combo"
        /// </summary>
        public static LocalisableString SizeOnCombo => new TranslatableString(getKey(@"change_size_based_on_combo"), @"Change size based on combo");

        /// <summary>
        /// "Decrease the flashlight size as combo increases."
        /// </summary>
        public static LocalisableString SizeOnComboDescription => new TranslatableString(getKey(@"decrease_the_flashlight_size_as"), @"Decrease the flashlight size as combo increases.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

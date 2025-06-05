// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OsuModAutopilotStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OsuModAutopilot";

        /// <summary>
        /// "Automatic cursor movement - just follow the rhythm."
        /// </summary>
        public static LocalisableString AutomaticCursorMovementJustFollow => new TranslatableString(getKey(@"automatic_cursor_movement_just_follow"), @"Automatic cursor movement - just follow the rhythm.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
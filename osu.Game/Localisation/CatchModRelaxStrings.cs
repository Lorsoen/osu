// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class CatchModRelaxStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.CatchModRelax";

        /// <summary>
        /// "Use the mouse to control the catcher."
        /// </summary>
        public static LocalisableString UseTheMouseToControl => new TranslatableString(getKey(@"use_the_mouse_to_control"), @"Use the mouse to control the catcher.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
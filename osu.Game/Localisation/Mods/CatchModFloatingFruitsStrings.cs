﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class CatchModFloatingFruitsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.CatchModFloatingFruits";

        /// <summary>
        /// "The fruits are... floating?"
        /// </summary>
        public static LocalisableString TheFruitsAreFloating => new TranslatableString(getKey(@"the_fruits_are_floating"), @"The fruits are... floating?");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

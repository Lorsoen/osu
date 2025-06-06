// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class OsuModTraceableStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.OsuModTraceable";

        /// <summary>
        /// "Put your faith in the approach circles..."
        /// </summary>
        public static LocalisableString PutYourFaithInThe => new TranslatableString(getKey(@"put_your_faith_in_the"), @"Put your faith in the approach circles...");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}

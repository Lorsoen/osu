// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModScoreV2Strings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModScoreV2";

        /// <summary>
        /// "Score set on earlier osu! versions with the V2 scoring algorithm active."
        /// </summary>
        public static LocalisableString ScoreSetOnEarlierOsu => new TranslatableString(getKey(@"score_set_on_earlier_osu"), @"Score set on earlier osu! versions with the V2 scoring algorithm active.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;
using osu.Framework.Bindables;
using osu.Framework.Localisation;
using osu.Game.Beatmaps;
using osu.Game.Configuration;
using osu.Game.Rulesets.Scoring;
using osu.Game.Localisation.Mods;

namespace osu.Game.Rulesets.Mods
{
    public abstract class ModEasyWithExtraLives : ModEasy, IApplicableFailOverride, IApplicableToHealthProcessor
    {
        [SettingSource(typeof(ModEasyWithExtraLivesStrings), nameof(ModEasyWithExtraLivesStrings.ExtraLives), nameof(ModEasyWithExtraLivesStrings.NumberOfExtraLives))]
        public Bindable<int> Retries { get; } = new BindableInt(2)
        {
            MinValue = 0,
            MaxValue = 10
        };

        public override IEnumerable<(LocalisableString setting, LocalisableString value)> SettingDescription
        {
            get
            {
                if (!Retries.IsDefault)
                    yield return (ModEasyWithExtraLivesStrings.Extralives, "lives".ToQuantity(Retries.Value));
            }
        }

        public override Type[] IncompatibleMods => base.IncompatibleMods.Append(typeof(ModAccuracyChallenge)).ToArray();

        private int retries;

        private readonly BindableNumber<double> health = new BindableDouble();

        public override void ApplyToDifficulty(BeatmapDifficulty difficulty)
        {
            base.ApplyToDifficulty(difficulty);
            retries = Retries.Value;
        }

        public bool PerformFail()
        {
            if (retries == 0) return true;

            health.Value = health.MaxValue;
            retries--;

            return false;
        }

        public bool RestartOnFail => false;

        public void ApplyToHealthProcessor(HealthProcessor healthProcessor)
        {
            health.BindTo(healthProcessor.Health);
        }
    }
}

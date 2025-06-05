// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Linq;
using osu.Framework.Bindables;
using osu.Framework.Localisation;
using osu.Game.Configuration;
using osu.Game.Rulesets.Mania.UI;
using osu.Game.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModCover : ManiaModWithPlayfieldCover
    {
        public override string Name => "Cover";
        public override string Acronym => "CO";

        public override LocalisableString Description => ManiaModCoverStrings.DecreaseThePlayfieldsViewingArea;

        public override double ScoreMultiplier => 1;

        protected override CoverExpandDirection ExpandDirection => Direction.Value;

        public override Type[] IncompatibleMods => base.IncompatibleMods.Concat(new[]
        {
            typeof(ManiaModHidden),
            typeof(ManiaModFadeIn)
        }).ToArray();

        public override bool Ranked => false;

        public override bool ValidForFreestyleAsRequiredMod => false;

        [SettingSource(typeof(ManiaModCoverStrings), nameof(ManiaModCoverStrings.Coverage), nameof(ManiaModCoverStrings.TheProportionOfPlayfieldHeight))]
        public override BindableNumber<float> Coverage { get; } = new BindableFloat(0.5f)
        {
            Precision = 0.1f,
            MinValue = 0.2f,
            MaxValue = 0.8f,
            Default = 0.5f,
        };

        [SettingSource(typeof(ManiaModCoverStrings), nameof(ManiaModCoverStrings.Direction), nameof(ManiaModCoverStrings.TheDirectionOnWhichThe))]
        public Bindable<CoverExpandDirection> Direction { get; } = new Bindable<CoverExpandDirection>();
    }
}

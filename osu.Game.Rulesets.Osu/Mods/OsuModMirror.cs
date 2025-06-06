// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Bindables;
using osu.Framework.Localisation;
using osu.Game.Configuration;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Osu.Objects;
using osu.Game.Rulesets.Osu.Utils;
using osu.Game.Localisation;
using osu.Game.Localisation.Mods;

namespace osu.Game.Rulesets.Osu.Mods
{
    public class OsuModMirror : ModMirror, IApplicableToHitObject
    {
        public override LocalisableString Description => OsuModMirrorStrings.FlipObjectsOnTheChosen;
        public override Type[] IncompatibleMods => new[] { typeof(ModHardRock) };

        [SettingSource(typeof(OsuModMirrorStrings), nameof(OsuModMirrorStrings.FlippedAxes))]
        public Bindable<MirrorType> Reflection { get; } = new Bindable<MirrorType>();

        public void ApplyToHitObject(HitObject hitObject)
        {
            var osuObject = (OsuHitObject)hitObject;

            switch (Reflection.Value)
            {
                case MirrorType.Horizontal:
                    OsuHitObjectGenerationUtils.ReflectHorizontallyAlongPlayfield(osuObject);
                    break;

                case MirrorType.Vertical:
                    OsuHitObjectGenerationUtils.ReflectVerticallyAlongPlayfield(osuObject);
                    break;

                case MirrorType.Both:
                    OsuHitObjectGenerationUtils.ReflectHorizontallyAlongPlayfield(osuObject);
                    OsuHitObjectGenerationUtils.ReflectVerticallyAlongPlayfield(osuObject);
                    break;
            }
        }

        public enum MirrorType
        {
            [LocalisableDescription(typeof(CommonStrings), nameof(CommonStrings.Horizontal))]
            Horizontal,
            [LocalisableDescription(typeof(CommonStrings), nameof(CommonStrings.Vertical))]
            Vertical,
            [LocalisableDescription(typeof(CommonStrings), nameof(CommonStrings.Both))]
            Both
        }
    }
}

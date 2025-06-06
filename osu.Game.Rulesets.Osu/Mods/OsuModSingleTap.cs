// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Linq;
using osu.Framework.Localisation;
using osu.Game.Localisation.Mods;

namespace osu.Game.Rulesets.Osu.Mods
{
    public class OsuModSingleTap : InputBlockingMod
    {
        public override string Name => @"Single Tap";
        public override string Acronym => @"SG";
        public override LocalisableString Description => OsuModSingleTapStrings.YouMustOnlyUseOne;
        public override Type[] IncompatibleMods => base.IncompatibleMods.Concat(new[] { typeof(OsuModAlternate) }).ToArray();

        protected override bool CheckValidNewAction(OsuAction action) => LastAcceptedAction == null || LastAcceptedAction == action;
    }
}

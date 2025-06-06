// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;
using osu.Game.Localisation.Mods;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey6 : ManiaKeyMod
    {
        public override int KeyCount => 6;
        public override string Name => "Six Keys";
        public override string Acronym => "6K";
        public override LocalisableString Description => ManiaModKey6Strings.PlayWithSixKeys;
    }
}

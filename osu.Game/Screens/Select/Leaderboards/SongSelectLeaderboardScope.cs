// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;
using osu.Framework.Localisation;
using osu.Game.Resources.Localisation;

namespace osu.Game.Screens.Select.Leaderboards
{
    public enum SongSelectLeaderboardScope
    {
        [Description("Local")]
        Local,

        [Description("Global")]
        Global,

        [Description("Gameplay")]
        Country,

        [Description("Friend")]
        Friend,

        [Description("Team")]
        Team,
    }
}

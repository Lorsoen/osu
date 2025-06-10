// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Screens.Select.Leaderboards;
using osu.Game.Graphics.UserInterface;
using osu.Framework.Allocation;
using osuTK.Graphics;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Input.Events;
using osu.Framework.Graphics;

namespace osu.Game.Overlays.BeatmapSet
{
    public partial class LeaderboardScopeSelector : GradientLineTabControl<BeatmapLeaderboardScopeLong>
    {
        protected override bool AddEnumEntriesAutomatically => false;

        protected override TabItem<BeatmapLeaderboardScopeLong> CreateTabItem(BeatmapLeaderboardScopeLong value) => new ScopeSelectorTabItem(value);

        public LeaderboardScopeSelector()
        {
            AddItem(BeatmapLeaderboardScopeLong.Global);
            AddItem(BeatmapLeaderboardScopeLong.Country);
            AddItem(BeatmapLeaderboardScopeLong.Friend);
            AddItem(BeatmapLeaderboardScopeLong.Team);
        }

        [BackgroundDependencyLoader]
        private void load(OverlayColourProvider colourProvider)
        {
            AccentColour = colourProvider.Highlight1;
            LineColour = colourProvider.Background1;
        }

        private partial class ScopeSelectorTabItem : PageTabItem
        {
            public ScopeSelectorTabItem(BeatmapLeaderboardScopeLong value)
                : base(value)
            {
            }

            protected override bool OnHover(HoverEvent e)
            {
                Text.FadeColour(AccentColour);

                return base.OnHover(e);
            }

            protected override void OnHoverLost(HoverLostEvent e)
            {
                base.OnHoverLost(e);

                Text.FadeColour(Color4.White);
            }
        }
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using System;
using System.Linq;
using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Game.Beatmaps;
using osu.Game.Configuration;
using osu.Game.Screens.Select.Leaderboards;

namespace osu.Game.Screens.Select
{
    public partial class PlayBeatmapDetailArea : BeatmapDetailArea
    {
        public readonly BeatmapLeaderboard Leaderboard;

        public override WorkingBeatmap Beatmap
        {
            get => base.Beatmap;
            set
            {
                base.Beatmap = value;

                Leaderboard.BeatmapInfo = value is DummyWorkingBeatmap ? null : value?.BeatmapInfo;
            }
        }

        private Bindable<BeatmapDetailTab> selectedTab;

        private Bindable<bool> selectedModsFilter;

        public PlayBeatmapDetailArea()
        {
            Add(Leaderboard = new BeatmapLeaderboard { RelativeSizeAxes = Axes.Both });
        }

        [BackgroundDependencyLoader]
        private void load(OsuConfigManager config)
        {
            selectedTab = config.GetBindable<BeatmapDetailTab>(OsuSetting.BeatmapDetailTab);
            selectedModsFilter = config.GetBindable<bool>(OsuSetting.BeatmapDetailModsFilter);

            selectedTab.BindValueChanged(tab => CurrentTab.Value = getTabItemFromTabType(tab.NewValue), true);
            CurrentTab.BindValueChanged(tab => selectedTab.Value = getTabTypeFromTabItem(tab.NewValue));

            selectedModsFilter.BindValueChanged(checkbox => CurrentModsFilter.Value = checkbox.NewValue, true);
            CurrentModsFilter.BindValueChanged(checkbox => selectedModsFilter.Value = checkbox.NewValue);
        }

        public override void Refresh()
        {
            base.Refresh();

            Leaderboard.RefetchScores();
        }

        protected override void OnTabChanged(BeatmapDetailAreaTabItem tab, bool selectedMods)
        {
            base.OnTabChanged(tab, selectedMods);

            Leaderboard.FilterMods = selectedMods;

            switch (tab)
            {
                case BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong> leaderboard:
                    Leaderboard.Scope = leaderboard.Scope;
                    Leaderboard.Show();
                    break;

                default:
                    Leaderboard.Hide();
                    break;
            }
        }

        protected override BeatmapDetailAreaTabItem[] CreateTabItems() => base.CreateTabItems().Concat(new BeatmapDetailAreaTabItem[]
        {
            new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Local),
            new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Global),
            new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Country),
            new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Friend),
            new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Team),
        }).ToArray();

        private BeatmapDetailAreaTabItem getTabItemFromTabType(BeatmapDetailTab type)
        {
            switch (type)
            {
                case BeatmapDetailTab.Details:
                    return new BeatmapDetailAreaDetailTabItem();

                case BeatmapDetailTab.Local:
                    return new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Local);

                case BeatmapDetailTab.Global:
                    return new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Global);

                case BeatmapDetailTab.Country:
                    return new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Country);

                case BeatmapDetailTab.Friends:
                    return new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Friend);

                case BeatmapDetailTab.Team:
                    return new BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong>(BeatmapLeaderboardScopeLong.Team);

                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }

        private BeatmapDetailTab getTabTypeFromTabItem(BeatmapDetailAreaTabItem item)
        {
            switch (item)
            {
                case BeatmapDetailAreaDetailTabItem:
                    return BeatmapDetailTab.Details;

                case BeatmapDetailAreaLeaderboardTabItem<BeatmapLeaderboardScopeLong> leaderboardTab:
                    switch (leaderboardTab.Scope)
                    {
                        case BeatmapLeaderboardScopeLong.Local:
                            return BeatmapDetailTab.Local;

                        case BeatmapLeaderboardScopeLong.Country:
                            return BeatmapDetailTab.Country;

                        case BeatmapLeaderboardScopeLong.Global:
                            return BeatmapDetailTab.Global;

                        case BeatmapLeaderboardScopeLong.Friend:
                            return BeatmapDetailTab.Friends;

                        case BeatmapLeaderboardScopeLong.Team:
                            return BeatmapDetailTab.Team;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(item));
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(item));
            }
        }
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Localisation;
using osu.Game.Configuration;
using osu.Game.Graphics.UserInterface;
using osu.Game.Graphics.UserInterfaceV2;
using osu.Game.Localisation;
using osu.Game.Screens.Select;
using osu.Game.Screens.Select.Leaderboards;
using osuTK;

namespace osu.Game.Screens.SelectV2
{
    public partial class BeatmapDetailsArea
    {
        public partial class Header : CompositeDrawable
        {
            private WedgeSelector<Selection> tabControl = null!;
            private FillFlowContainer leaderboardControls = null!;

            private ShearedDropdown<BeatmapLeaderboardScopeLong> scopeDropdown = null!;
            private ShearedToggleButton selectedModsToggle = null!;

            public IBindable<Selection> Type => tabControl.Current;

            public IBindable<BeatmapLeaderboardScopeLong> Scope => scopeDropdown.Current;

            private readonly Bindable<BeatmapDetailTab> configDetailTab = new Bindable<BeatmapDetailTab>();

            public IBindable<bool> FilterBySelectedMods => selectedModsToggle.Active;

            [BackgroundDependencyLoader]
            private void load(OsuConfigManager config)
            {
                InternalChildren = new Drawable[]
                {
                    new Container
                    {
                        RelativeSizeAxes = Axes.Both,
                        Padding = new MarginPadding { Left = SongSelect.WEDGE_CONTENT_MARGIN, Right = 20f },
                        Children = new Drawable[]
                        {
                            tabControl = new WedgeSelector<Selection>(20f)
                            {
                                Anchor = Anchor.CentreLeft,
                                Origin = Anchor.CentreLeft,
                                Width = 200,
                                Height = 22,
                                Margin = new MarginPadding { Top = 2f },
                                IsSwitchable = true,
                            },
                            leaderboardControls = new FillFlowContainer
                            {
                                Anchor = Anchor.CentreRight,
                                Origin = Anchor.CentreRight,
                                AutoSizeAxes = Axes.Both,
                                Spacing = new Vector2(5f, 0f),
                                Children = new Drawable[]
                                {
                                    new Container
                                    {
                                        Anchor = Anchor.CentreRight,
                                        Origin = Anchor.CentreRight,
                                        Size = new Vector2(128f, 30f),
                                        Child = selectedModsToggle = new ShearedToggleButton
                                        {
                                            Anchor = Anchor.Centre,
                                            Origin = Anchor.Centre,
                                            Text = BeatmapDetailsAreaStrings.SelectedMods,
                                            Height = 30,
                                        },
                                    },
                                    // new Container
                                    // {
                                    //     Anchor = Anchor.CentreRight,
                                    //     Origin = Anchor.CentreRight,
                                    //     Size = new Vector2(150f, 33f),
                                    //     Child = new ShearedDropdown<RankingsSort>(@"Sort")
                                    //     {
                                    //         Width = 150f,
                                    //         Items = Enum.GetValues<RankingsSort>(),
                                    //     },
                                    // },
                                    new Container
                                    {
                                        Anchor = Anchor.CentreRight,
                                        Origin = Anchor.CentreRight,
                                        Size = new Vector2(160f, 32f),
                                        Child = scopeDropdown = new ScopeDropdown
                                        {
                                            Width = 160f,
                                            Current = { Value = BeatmapLeaderboardScopeLong.Global },
                                        },
                                    },
                                },
                            },
                        },
                    },
                };

                config.BindWith(OsuSetting.BeatmapDetailTab, configDetailTab);
                config.BindWith(OsuSetting.BeatmapDetailModsFilter, selectedModsToggle.Active);
            }

            protected override void LoadComplete()
            {
                base.LoadComplete();

                scopeDropdown.Current.Value = tryMapDetailTabToLeaderboardScope(configDetailTab.Value) ?? scopeDropdown.Current.Value;
                scopeDropdown.Current.BindValueChanged(_ => updateConfigDetailTab());

                tabControl.Current.Value = configDetailTab.Value == BeatmapDetailTab.Details ? Selection.Details : Selection.Ranking;
                tabControl.Current.BindValueChanged(v =>
                {
                    leaderboardControls.FadeTo(v.NewValue == Selection.Ranking ? 1 : 0, 300, Easing.OutQuint);
                    updateConfigDetailTab();
                }, true);
            }

            #region Reading / writing state from / to configuration

            private void updateConfigDetailTab()
            {
                switch (tabControl.Current.Value)
                {
                    case Selection.Details:
                        configDetailTab.Value = BeatmapDetailTab.Details;
                        return;

                    case Selection.Ranking:
                        configDetailTab.Value = mapLeaderboardScopeToDetailTab(scopeDropdown.Current.Value);
                        return;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(tabControl.Current.Value), tabControl.Current.Value, null);
                }
            }

            private static BeatmapLeaderboardScopeLong? tryMapDetailTabToLeaderboardScope(BeatmapDetailTab tab)
            {
                switch (tab)
                {
                    case BeatmapDetailTab.Local:
                        return BeatmapLeaderboardScopeLong.Local;

                    case BeatmapDetailTab.Country:
                        return BeatmapLeaderboardScopeLong.Country;

                    case BeatmapDetailTab.Global:
                        return BeatmapLeaderboardScopeLong.Global;

                    case BeatmapDetailTab.Friends:
                        return BeatmapLeaderboardScopeLong.Friend;

                    case BeatmapDetailTab.Team:
                        return BeatmapLeaderboardScopeLong.Team;

                    default:
                        return null;
                }
            }

            private static BeatmapDetailTab mapLeaderboardScopeToDetailTab(BeatmapLeaderboardScopeLong scope)
            {
                switch (scope)
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
                        throw new ArgumentOutOfRangeException(nameof(scope), scope, null);
                }
            }

            #endregion

            public enum Selection
            {
                Details,
                Ranking,
            }

            // public enum RankingsSort
            // {
            //     Score,
            //     Accuracy,
            //     Combo,
            //     Misses,
            //     Date,
            // }

            private partial class ScopeDropdown : ShearedDropdown<BeatmapLeaderboardScopeLong>
            {
                public ScopeDropdown()
                    : base(BeatmapDetailsAreaStrings.Scope)
                {
                    Items = Enum.GetValues<BeatmapLeaderboardScopeLong>();
                }
            }
        }
    }
}

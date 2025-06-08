// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Linq;
using osu.Framework.Extensions.TypeExtensions;
using osu.Framework.Threading;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Types;
using osu.Game.Localisation;

namespace osu.Game.Screens.Edit.Compose.Components
{
    public partial class HitObjectInspector : EditorInspector
    {
        protected override void LoadComplete()
        {
            base.LoadComplete();

            EditorBeatmap.SelectedHitObjects.CollectionChanged += (_, _) => updateInspectorText();
            EditorBeatmap.PlacementObject.BindValueChanged(_ => updateInspectorText());
            EditorBeatmap.TransactionBegan += updateInspectorText;
            EditorBeatmap.TransactionEnded += updateInspectorText;
            updateInspectorText();
        }

        private ScheduledDelegate? rollingTextUpdate;

        private void updateInspectorText()
        {
            InspectorText.Clear();
            rollingTextUpdate?.Cancel();
            rollingTextUpdate = null;

            HitObject[] objects;

            if (EditorBeatmap.SelectedHitObjects.Count > 0)
                objects = EditorBeatmap.SelectedHitObjects.ToArray();
            else if (EditorBeatmap.PlacementObject.Value != null)
                objects = new[] { EditorBeatmap.PlacementObject.Value };
            else
                objects = Array.Empty<HitObject>();

            AddInspectorValues(objects);

            // I'd hope there's a better way to do this, but I don't want to bind to each and every property above to watch for changes.
            // This is a good middle-ground for the time being.
            if (objects.Length > 0)
                rollingTextUpdate ??= Scheduler.AddDelayed(updateInspectorText, 250);
        }

        protected virtual void AddInspectorValues(HitObject[] objects)
        {
            switch (objects.Length)
            {
                case 0:
                    AddValue(HitObjectInspectorStrings.NoSelection);
                    break;

                case 1:
                    var selected = objects.Single();

                    AddHeader(HitObjectInspectorStrings.Type);
                    AddValue($"{selected.GetType().ReadableName()}");

                    AddHeader(HitObjectInspectorStrings.Time);
                    AddValue($"{selected.StartTime:#,0.##}ms");

                    switch (selected)
                    {
                        case IHasPosition pos:
                            AddHeader(HitObjectInspectorStrings.Position);
                            AddValue($"x:{pos.X:#,0.##}");
                            AddValue($"y:{pos.Y:#,0.##}");
                            break;

                        case IHasXPosition x:
                            AddHeader(HitObjectInspectorStrings.Position);

                            AddValue($"x:{x.X:#,0.##} ");
                            break;

                        case IHasYPosition y:
                            AddHeader(HitObjectInspectorStrings.Position);

                            AddValue($"y:{y.Y:#,0.##}");
                            break;
                    }

                    if (selected is IHasDistance distance)
                    {
                        AddHeader(HitObjectInspectorStrings.Distance);
                        AddValue($"{distance.Distance:#,0.##}px");
                    }

                    if (selected is IHasSliderVelocity sliderVelocity)
                    {
                        AddHeader(HitObjectInspectorStrings.SliderVelocity);
                        AddValue($"{sliderVelocity.SliderVelocityMultiplier:#,0.00}x ({sliderVelocity.SliderVelocityMultiplier * EditorBeatmap.Difficulty.SliderMultiplier:#,0.00}x)");
                    }

                    if (selected is IHasRepeats repeats)
                    {
                        AddHeader(HitObjectInspectorStrings.Repeats);
                        AddValue($"{repeats.RepeatCount:#,0.##}");
                    }

                    if (selected is IHasDuration duration)
                    {
                        AddHeader(HitObjectInspectorStrings.EndTime);
                        AddValue($"{duration.EndTime:#,0.##}ms");
                        AddHeader(HitObjectInspectorStrings.Duration);
                        AddValue($"{duration.Duration:#,0.##}ms");
                    }

                    break;

                default:
                    AddHeader(HitObjectInspectorStrings.SelectedObjects);
                    AddValue($"{objects.Length:#,0.##}");

                    AddHeader(HitObjectInspectorStrings.StartTime);
                    AddValue($"{objects.Min(o => o.StartTime):#,0.##}ms");

                    AddHeader(HitObjectInspectorStrings.EndTime);
                    AddValue($"{objects.Max(o => o.GetEndTime()):#,0.##}ms");
                    break;
            }
        }
    }
}

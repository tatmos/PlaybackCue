using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class PlaybackCueClip : PlayableAsset, ITimelineClipAsset
{
    public PlaybackCueBehaviour template = new PlaybackCueBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<PlaybackCueBehaviour>.Create (graph, template);
        return playable;    }
}

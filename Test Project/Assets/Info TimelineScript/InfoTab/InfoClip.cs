using UnityEngine;
using TMPro;
using UnityEngine.Timeline;
using UnityEngine.Playables;

[System.Serializable]
public class InfoClip : PlayableAsset, ITimelineClipAsset
{
    public string header;
    [TextArea(1,4)]
    public string body;
    public string NextButtonText = "Next";
    public string PrevButtonText = "Prev";
    public bool IsNext = true;
    public bool IsPrev = true;
    [System.NonSerialized]public InfoManager infoManager;

    public ClipCaps clipCaps => ClipCaps.All;


    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<InfoBehaviour>.Create(graph);
        InfoBehaviour behaviour = playable.GetBehaviour();
        behaviour.infoManager = infoManager;

        behaviour.Header = header;
        behaviour.Body = body;
        behaviour.NextButtonText = NextButtonText;
        behaviour.PrevButtonText = PrevButtonText;
        behaviour.IsNext = IsNext;
        behaviour.IsPrev = IsPrev;

        return playable;
    }
}

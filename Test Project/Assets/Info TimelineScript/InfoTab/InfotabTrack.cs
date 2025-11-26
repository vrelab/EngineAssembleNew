using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


[TrackBindingType(typeof(GameObject))]
[TrackClipType(typeof(InfoClip))]
public class InfotabTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        var Comp = go.GetComponent<PlayableDirector>().GetGenericBinding(this) as GameObject;
        if (Comp == null)
        {

        }
        else
        {
            InfoManager infomanager;
            if(!Comp.TryGetComponent(out infomanager))
            {

            }
            else
            {
                foreach(var c in GetClips())
                {
                    ((InfoClip)(c.asset)).infoManager = infomanager;
                }
            }            
        }
        return ScriptPlayable<InfoBehaviour>.Create(graph, inputCount);
    }

}

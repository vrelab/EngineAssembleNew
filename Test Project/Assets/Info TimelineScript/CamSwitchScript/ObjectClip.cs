using UnityEngine;
using UnityEngine.Playables;

public class ObjectClip : PlayableAsset
{
    public Vector3 Objectpos;
    public float FocalPoint;
    public ExposedReference<GameObject> ObjectSwitch;
    //public bool PlayerStatic = true;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<Objectbehaviour>.Create(graph);
        Objectbehaviour objectbehaviour = playable.GetBehaviour();

        objectbehaviour.ObjectPos = Objectpos;
        objectbehaviour.FocalPoint = FocalPoint;

        GameObject resolvedPlayer = ObjectSwitch.Resolve(graph.GetResolver());

        objectbehaviour.ObjectSwitch = resolvedPlayer;
        
        return playable;
    }
}

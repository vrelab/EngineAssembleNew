using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Playables;

public class InfoBehaviour : PlayableBehaviour
{
    public string Header;
    public string Body;
    public Button Next;
    public Button Prev;
    public string NextButtonText;
    public string PrevButtonText;
    public bool IsNext;
    public bool IsPrev;

    public InfoManager infoManager; 
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        var clipTime = playable.GetTime();
        if (info.effectivePlayState == PlayState.Playing && clipTime <= 0.1f)
        {
            if (infoManager == null)
            {
                //Debug.LogWarning("InfoManager is not assigned!");
                return;
            }
            infoManager.UpdatePanel(header: Header, bodyContent: Body,nextButtonText:NextButtonText, prevButtonText:PrevButtonText, isNext:IsNext, isPrev:IsPrev);
        }
    }
}

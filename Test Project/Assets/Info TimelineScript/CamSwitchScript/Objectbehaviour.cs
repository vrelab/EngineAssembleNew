using UnityEngine;
using UnityEngine.Playables;

public class Objectbehaviour : PlayableBehaviour
{
    public Vector3 ObjectPos;
    public float FocalPoint; // Rotation value for the y-axis
    public GameObject ObjectSwitch;
    //public bool PlayerStatic = true;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        // Set object's position and Y-axis rotation
        if (ObjectSwitch != null)
        {
            ObjectSwitch.transform.position = ObjectPos;
            ObjectSwitch.transform.rotation = Quaternion.Euler(0, FocalPoint, 0);

            // Toggle CharacterController based on PlayerStatic
            /*var controller = OVRPlayer.GetComponent<CharacterController>();
            if (controller) controller.enabled = PlayerStatic;*/
        }
    }
}

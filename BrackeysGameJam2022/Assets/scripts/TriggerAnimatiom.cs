using UnityEngine;

public class TriggerAnimatiom : MonoBehaviour
{
    public Animator armsanimation;

    public void VRonAnimation()
    {
        armsanimation.Play("VRon");
    }

    public void VRoffAnimation()
    {
        armsanimation.Play("VRoff");
    }
}

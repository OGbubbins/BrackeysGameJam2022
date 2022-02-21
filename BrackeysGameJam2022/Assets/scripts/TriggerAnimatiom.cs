using UnityEngine;

public class TriggerAnimatiom : MonoBehaviour
{
    [SerializeField] private Animator armsanimation;

    public void VRonAnimation()
    {
        armsanimation.Play("VRon");
    }

    public void VRoffAnimation()
    {
        armsanimation.Play("VRoff");
    }
}

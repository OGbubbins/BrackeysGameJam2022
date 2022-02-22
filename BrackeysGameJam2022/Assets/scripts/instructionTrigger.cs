using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class instructionTrigger : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI instructionText;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("working");
        instructionText.text = "Right Click to take off your VR headset and reveal the real world, be careful not to use it for too long otherwise you will be poisoned";

        Destroy(instructionText, 5);
    }
}

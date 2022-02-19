using UnityEngine;

public class follow : MonoBehaviour
{

    public Transform camerafollow;
    public float friction;

    

    // Update is called once per frame
    public void Movecamera()
    {
        transform.position = Vector3.Lerp(transform.position, camerafollow.position, friction * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, camerafollow.rotation, friction) * Quaternion.Euler(Time.deltaTime, Time.deltaTime, Time.deltaTime);

    }
}

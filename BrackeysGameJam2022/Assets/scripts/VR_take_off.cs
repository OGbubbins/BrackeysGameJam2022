using UnityEngine;

public class VR_take_off : MonoBehaviour
{
    float Health;
    [SerializeField] int Maxhealth;
    [SerializeField] float healthDecreaseSpeed;

    void Start()
    {
        FindObjectOfType<healthbar>().setmaxhealth(Maxhealth);
        Health = Maxhealth;

        GameObject[] invisibleList = GameObject.FindGameObjectsWithTag("Invisible");

        foreach (GameObject item in invisibleList)
        {
            item.GetComponent<MeshRenderer>().enabled = false;
        }

    }

    void Update()
    {
        GameObject[] invisibleList = GameObject.FindGameObjectsWithTag("Invisible");
        
        if (Input.GetMouseButton(1) && Health > 0)
        {
            Health -= healthDecreaseSpeed * Time.deltaTime;
            Debug.Log(Health);
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (Health > 0)
            {
                foreach (GameObject item in invisibleList)
                {
                    item.GetComponent<MeshRenderer>().enabled = true;
                }
            }
            
        }

        if (Input.GetMouseButtonUp(1) || Health == 0)
        {
            foreach (GameObject item in invisibleList)
            {
                item.GetComponent<MeshRenderer>().enabled = false;
            }
        }



        if (Health < 0)
        {
            Health = 0;
        }

        FindObjectOfType<healthbar>().SetHealth(Health);

    }
}

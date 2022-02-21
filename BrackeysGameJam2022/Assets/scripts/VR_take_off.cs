using UnityEngine;
using UnityEngine.SceneManagement;
public class VR_take_off : MonoBehaviour
{
    float Health;
    [SerializeField] int Maxhealth;
    [SerializeField] float healthDecreaseSpeed;

    void Start()
    {
        FindObjectOfType<healthbar>().setmaxhealth(Maxhealth);
        Health = Maxhealth;

        GameObject[] RealList = GameObject.FindGameObjectsWithTag("Real");

        foreach (GameObject item in RealList)
        {
            item.GetComponent<MeshRenderer>().enabled = false;
        }

        GameObject[] FakeList = GameObject.FindGameObjectsWithTag("Fake");

        foreach (GameObject item in FakeList)
        {
            item.GetComponent<MeshRenderer>().enabled = true;
        }


    }

    void Update()
    {
        GameObject[] RealList = GameObject.FindGameObjectsWithTag("Real");
        GameObject[] FakeList = GameObject.FindGameObjectsWithTag("Fake");

        if (Input.GetMouseButton(1) && Health > 0)
        {
            Health -= healthDecreaseSpeed * Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(1) && Health > 0)
        {
            
            
            foreach (GameObject item in RealList)
            {
                item.GetComponent<MeshRenderer>().enabled = true;
            }

            foreach (GameObject item in FakeList)
            {
                item.GetComponent<MeshRenderer>().enabled = false;
            }
            
            
        }

        if (Input.GetMouseButtonUp(1) || Health == 0)
        {
            foreach (GameObject item in RealList)
            {
                item.GetComponent<MeshRenderer>().enabled = false;
            }

            foreach (GameObject item in FakeList)
            {
                item.GetComponent<MeshRenderer>().enabled = true;
            }
        }



        if (Health < 0)
        {
            Health = 0;
        }

        if (Health == 0)
        {
            SceneManager.LoadScene("Game Over");
        }

        FindObjectOfType<healthbar>().SetHealth(Health);

    }
}

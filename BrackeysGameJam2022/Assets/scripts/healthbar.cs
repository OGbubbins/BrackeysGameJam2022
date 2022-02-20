using UnityEngine.UI;
using UnityEngine;

public class healthbar : MonoBehaviour
{

    public Slider slider;

    public void setmaxhealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(float health)
    {
        slider.value = health;
    }

}

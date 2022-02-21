using UnityEngine.UI;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    public Gradient gradient;
    public Slider slider;
    public Image fill;

    public void setmaxhealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(float health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}

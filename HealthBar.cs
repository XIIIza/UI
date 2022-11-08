using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void ChangeHealth(float health)
    {
        _slider.value = Mathf.MoveTowards(_slider.value, health, 1f);
    }
}
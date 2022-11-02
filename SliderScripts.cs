using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SliderScripts : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void ChangeHealth(float health)
    {
        StartCoroutine(ChangeHealthDelay(health));
    }

    private IEnumerator ChangeHealthDelay(float health)
    {
        var waitForSecond = new WaitForSeconds(1f);

        yield return waitForSecond;

        Debug.Log("Slided");
        _slider.DOValue(health, 0.5f);
    }
}
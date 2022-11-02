using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private SliderScripts _sliderScripts;

    private float _health;
    private float _damage = 10f;
    private float _heal = 10f;
    private float _maxHealth = 100;

    private void OnEnable()
    {
        _health = _maxHealth;
    }

    public void TakeHealth()
    {
        _health += _heal;

        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }

        Debug.Log("Cured");

        _sliderScripts.ChangeHealth(_health);
    }

    public void TakeDamaage()
    {
        _health -= _damage;

        if (_health < 0)
        {
            _health = 0;
        }

        Debug.Log("Damaged");

        _sliderScripts.ChangeHealth(_health);
    }
}
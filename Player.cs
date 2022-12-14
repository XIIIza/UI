using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private float _health;
    private float _damage = 10f;
    private float _heal = 10f;
    private float _maxHealth = 100;

    private Coroutine _changeHealthCorutine;

    private void OnEnable()
    {
        _health = _maxHealth;
    }

    public void TakeHealth()
    {
        if (_changeHealthCorutine != null)
        {
            StopCoroutine(_changeHealthCorutine);
        }

        _health += _heal;

        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }

        Debug.Log("Cured");

        _changeHealthCorutine = StartCoroutine(ChangeHealthCorutine(_health));
    }

    public void TakeDamaage()
    {
        if (_changeHealthCorutine != null)
        {
            StopCoroutine(_changeHealthCorutine);
        }

        _health -= _damage;

        if (_health < 0)
        {
            _health = 0;
        }

        Debug.Log("Damaged");

        _changeHealthCorutine = StartCoroutine(ChangeHealthCorutine(_health));
    }

    private IEnumerator ChangeHealthCorutine(float health)
    {
        var waitForSecond = new WaitForSeconds(0.05f);

        bool isCorrectValue = false;

        while (!isCorrectValue)
        {
            isCorrectValue = _healthBar.ChangeHealth(_health);

            yield return waitForSecond;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager: MonoBehaviour
{
    [SerializeField]
    private int _maxHearts = 3;
    [SerializeField]
    private float _invincibilitySeconds = 4;

    private float _lastTimeTookDamage = 0;
    private int _curHearts = 3;


    public void ResetHealth()
    {
        _curHearts = _maxHearts;
    }

    public void TakeDamage()
    {
        if (Time.time > _lastTimeTookDamage + _invincibilitySeconds)
        {
            Debug.Log("Damage taken! Last took damage at " + _lastTimeTookDamage);

            _lastTimeTookDamage = Time.time;
            _curHearts--;


            if (_curHearts < 0)
            {
                //TODO Trigger Gameover
            }
        }
    }

    public void RestoreHealth(int numHearts)
    {
        _curHearts += numHearts;
        _curHearts = Mathf.Min(_maxHearts, _curHearts);
    }

}

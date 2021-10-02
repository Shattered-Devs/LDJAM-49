using System;
using UnityEngine;

public class PlayerHealthManager: MonoBehaviour
{
    [SerializeField]
    private HealthBar _healthBar;
    [SerializeField]
    private int _maxHearts = 3;
    [SerializeField]
    private float _invincibilitySeconds = 4;

    private float _lastTimeTookDamage = 0;
    private int _curHearts = 0;

    private void Start()
    {
        // Linuxydable comments: For modularity, always set the current health with the max health on the start of the game !
        _curHearts = _maxHearts;
    }


    public void ResetHealth()
    {
        _curHearts = _maxHearts;
    }

    public void TakeDamage()
    {
        if (Time.time > _lastTimeTookDamage + _invincibilitySeconds)
        {
            // Linuxydable comments: Always update variables before calling logs because it's can take more than 1 frame ! 
            _lastTimeTookDamage = Time.time;
            _curHearts--;
            
            Debug.Log("Damage taken! Last took damage at " + _lastTimeTookDamage);
            

            if (_curHearts < 0)
            {
                //TODO Trigger Gameover
                return; // Linuxydable comments: Return the function for avoid updating if the player is dead.
            }
            
            _healthBar.UpdateHealth(_curHearts, _maxHearts);
        }
    }

    public void RestoreHealth(int numHearts)
    {
        _curHearts += numHearts;
        _curHearts = Mathf.Min(_maxHearts, _curHearts);
    }

}

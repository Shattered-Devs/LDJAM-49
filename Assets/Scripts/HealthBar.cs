using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private RectTransform _healthBar;

    private void Start()
    {
        _healthBar = gameObject.GetComponent<RectTransform>();
    }

    public void UpdateHealth(int currentHealth, int maxHealth)
    {
        _healthBar.localScale = new Vector3(1.0f / ((float)maxHealth / currentHealth), 1, 1);
    }
}

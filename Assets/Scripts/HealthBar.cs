using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private RectTransform _healthBar;
    private float maxWidth;

    private void Start()
    {
        _healthBar = gameObject.GetComponent<RectTransform>();
        maxWidth = _healthBar.rect.width;
    }

    public void UpdateHealth(int currentHealth, int maxHealth)
    {
        _healthBar.sizeDelta = new Vector2(maxWidth * currentHealth / maxHealth, _healthBar.sizeDelta.y);
        Debug.Log("Width : "+  _healthBar.rect.width);
    }
}

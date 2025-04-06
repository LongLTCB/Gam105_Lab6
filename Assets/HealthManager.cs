using UnityEngine;
using UnityEngine.UI;  // Để làm việc với UI

public class HealthManager : MonoBehaviour
{
    public Slider healthSlider;   // Tham chiếu đến Slider máu
    public GameObject winPanel;   // Tham chiếu đến Panel chiến thắng

    public int maxHealth = 5;     // Số máu tối đa
    private int currentHealth = 0; // Số máu hiện tại

    void Start()
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
        winPanel.SetActive(false);  // Đảm bảo WinPanel không hiện khi game bắt đầu
    }

    public void AddHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthSlider.value = currentHealth;

        // Kiểm tra nếu máu đầy và hiển thị bảng chiến thắng
        if (currentHealth >= maxHealth)
        {
            Debug.Log("🎉 Chiến thắng!");
            winPanel.SetActive(true);  // Hiển thị bảng chiến thắng
        }
    }
}

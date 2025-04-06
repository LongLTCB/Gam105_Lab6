using UnityEngine;

public class EggCatcher : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Egg"))
        {
            Destroy(other.gameObject);

            GameManager.instance.AddScore(1); // Tăng điểm

            // Tăng máu mỗi khi bắt được trứng
            FindObjectOfType<HealthManager>().AddHealth(1);

            Debug.Log("Bắt được trứng! Điểm: " + GameManager.instance.Score);
        }
    }
}

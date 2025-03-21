using UnityEngine;

public class EggCatcher : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Egg"))
        {
            Destroy(other.gameObject);
            GameManager.instance.AddScore(1); // Sử dụng AddScore() để tăng điểm
            Debug.Log("Bắt được trứng! Điểm: " + GameManager.instance.Score); // Gọi getter Score
        }
    }
}
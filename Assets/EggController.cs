using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject eggBrokenPrefab; // Prefab trứng bể
    public AudioClip breakSound;       // Âm thanh trứng bể
    private AudioSource audioSource;   // Component phát âm thanh

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Log("eggBrokenPrefab: " + eggBrokenPrefab);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // Nếu chạm vào mặt đất
        {
            BreakEgg();
        }
    }

    void BreakEgg()
    {
        // Phát âm thanh trứng bể nếu có
        if (breakSound != null && audioSource != null)
        {
            AudioSource.PlayClipAtPoint(breakSound, transform.position);
        }

        // Tạo hiệu ứng trứng bể
        Instantiate(eggBrokenPrefab, transform.position, Quaternion.identity);

        // Xóa trứng cũ
        Destroy(gameObject);
    }
}

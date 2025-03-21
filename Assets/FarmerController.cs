using UnityEngine;

public class FarmerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Tốc độ di chuyển
    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Ánh xạ Rigidbody2D
        if (rb == null)
        {
            Debug.LogError(gameObject.name + " không có Rigidbody2D! Hãy kiểm tra lại.");
            return;
        }
    }

    void Update()
    {
        // Nhận input từ bàn phím
        moveInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // Di chuyển Farmer theo input
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }
}

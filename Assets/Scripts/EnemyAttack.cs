using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health; // Tham chiếu đến máu của chính mình (để tự hủy)
    public int damage = 1;     // Sát thương gây ra cho Player

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem va chạm có phải là Player không
        var playerHealth = collision.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            // Gây sát thương cho Player
            playerHealth.TakeDamage(damage);

            // Tự sát (gây 1000 sát thương cho chính mình để chết ngay lập tức)
            health.TakeDamage(1000);
        }
    }
}
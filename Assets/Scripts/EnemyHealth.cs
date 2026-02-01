using UnityEngine;

public class EnemyHealth : MonoBehaviour 
{
    public GameObject explosionPrefab; // Ô này để kéo Prefab vụ nổ vào

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        // Hàm này tự chạy khi có vật thể (đạn) chạm vào kẻ địch
        Die(); 
    }

    private void Die() 
    {
        // 1. Tạo hiệu ứng nổ tại vị trí của kẻ địch
        if (explosionPrefab != null) {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            // 2. Xóa hiệu ứng nổ sau 1 giây để tránh rác bộ nhớ
            Destroy(explosion, 1f); 
        }

        // 3. Xóa chính kẻ địch khỏi màn hình
        Destroy(gameObject);    
    }
}
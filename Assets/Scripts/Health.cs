using UnityEngine;

// Slide 9: Class cha quản lý máu chung
public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3;
    private int healthPoint;

    private void Start() => healthPoint = defaultHealthPoint;

    // QUAN TRỌNG: Phải có chữ public để script khác gọi được
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    // Hàm Die có thể được lớp con chỉnh sửa (virtual)
    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
    }
}
using UnityEngine;

// Slide 7: Kế thừa từ Health thay vì MonoBehaviour
public class EnemyHealth : Health
{
    // Ghi đè hàm Die để thêm dòng log riêng
    protected override void Die()
    {
        base.Die(); // Gọi hàm nổ của cha
        Debug.Log("Enemy died");
    }
}
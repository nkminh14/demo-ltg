using UnityEngine;

public class PlayerShootingg : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    public Vector3 bulletOffset; 
    private float lastBulletTime;

    void Update() 
    {
        UpdateFiring(); 
    }

    private void UpdateFiring() 
    {
        if (Input.GetMouseButton(0)) 
        {
            if (Time.time - lastBulletTime > shootingInterval) 
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
    }
}
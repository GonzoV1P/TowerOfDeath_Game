
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawn.forward * bulletSpeed;
        }
    }
}

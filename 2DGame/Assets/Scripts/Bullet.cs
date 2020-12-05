using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("爆炸特效")]
    public GameObject explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        GameObject temp = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(temp, 1.5f);
    }
}

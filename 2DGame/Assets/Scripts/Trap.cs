using UnityEngine;

/// <summary>
/// 陷阱
/// </summary>
public class Trap : MonoBehaviour
{
    [Header("要觸發的粒子")]
    public ParticleSystem ps;
    [Header("音效")]
    public AudioClip sound;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "玩家")
        {
            aud.PlayOneShot(sound);
            ps.Play();
            collision.GetComponent<Player>().Dead("陷阱");
        }
    }
}

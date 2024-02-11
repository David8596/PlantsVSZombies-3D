using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _armor;
    [SerializeField] private float _damage;
    [SerializeField] private float _speed;
    [SerializeField] private DetectedZombie _detectedZombie;

    public float Health => _health;
    public float Armor => _armor;
    public float Damage => _damage;
    public float Speed => _speed;

    private void FixedUpdate()
    {
        Move();

        if (Health <= 0)
        {
            Destroy(gameObject);
        }

    }

    private void Move()
    {
        Vector3 direction = Vector3.left;

        transform.Translate(direction * _speed * Time.deltaTime);
    }
}

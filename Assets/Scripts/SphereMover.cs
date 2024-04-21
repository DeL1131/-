
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(_speed * Time.deltaTime, 0, 0);
    }
}

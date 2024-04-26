using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float distance = transform.position.x * _moveSpeed * Time.deltaTime;

        transform.Translate(distance * Vector3.forward);
    }
}

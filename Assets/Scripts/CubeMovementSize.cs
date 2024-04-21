
using UnityEngine;

public class CubeMovementSize : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.localScale += new Vector3(_scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        float distance = transform.position.x * _moveSpeed * Time.deltaTime;

        transform.Translate(distance * Vector3.forward);
    }
}

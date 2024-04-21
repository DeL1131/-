
using UnityEngine;

public class CapsuleSize : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        ScaleUp();
    }

    private void ScaleUp()
    {
        transform.localScale += new Vector3(_scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime);
    }
}
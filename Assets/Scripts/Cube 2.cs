using UnityEngine;

public class Cube2 : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime);
    }
}

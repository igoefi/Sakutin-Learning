using UnityEngine;

public class Forwarder : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update() =>
        transform.position += transform.forward * _speed * Time.deltaTime;
}

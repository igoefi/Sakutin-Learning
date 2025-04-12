using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update() =>
        transform.Rotate(new(0, _speed * Time.deltaTime));
}

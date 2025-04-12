using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] float _speed;
    private void FixedUpdate() =>
        transform.Rotate(new(0, _speed));
}

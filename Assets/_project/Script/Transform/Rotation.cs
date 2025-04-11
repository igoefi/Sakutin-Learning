using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float _speed;
    private void FixedUpdate() =>
        transform.Rotate(new(0, _speed));
}

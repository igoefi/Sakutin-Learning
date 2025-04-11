using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] float _speed;
    private void FixedUpdate() =>
        transform.localScale += Vector3.one * _speed;
}

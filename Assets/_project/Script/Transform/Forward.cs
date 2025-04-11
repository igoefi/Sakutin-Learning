using UnityEngine;

public class Forward : MonoBehaviour
{
    private void FixedUpdate() =>
        transform.position += transform.forward * .1f;
}

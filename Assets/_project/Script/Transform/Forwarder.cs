using UnityEngine;

public class Forwarder : MonoBehaviour
{
    private void FixedUpdate() =>
        transform.position += transform.forward * .1f;
}

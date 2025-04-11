using UnityEngine;

public class ForwardScale : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position += transform.forward * 0.1f;
        transform.Rotate(new(0, 1));
        transform.localScale += Vector3.one * .1f;
    }
}

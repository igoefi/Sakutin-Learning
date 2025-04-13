using UnityEngine;

public class ShowCounter : MonoBehaviour
{
    private void Update() =>
        Debug.Log(Counter.Count);
}

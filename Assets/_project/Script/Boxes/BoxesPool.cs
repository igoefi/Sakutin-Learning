using UnityEngine;
using UnityEngine.Pool;

public class BoxesPool : MonoBehaviour
{
    public static PooledObject<Box> Pool { get; private set; }
}

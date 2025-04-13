using UnityEngine;

public class Box : MonoBehaviour
{
    private float _randomValue;

    public void SetParametrs(float randomValue, float scale)
    {
        _randomValue = randomValue;
        transform.localScale = Vector3.one * scale;
    }

    public void Click()
    {
        if(Random.value > _randomValue)
            Destroy(gameObject);

        
    }
}

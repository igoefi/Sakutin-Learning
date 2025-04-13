using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private Coroutine _corutine;
    public static float Count { get; private set; }
    private float _needTimeDelta = .5f;
    private float _timeDelta;
    private int _LMBIndex = 0;
    private void Update()
    {
        if (Input.GetMouseButtonDown(_LMBIndex))
            _corutine = StartCoroutine(AddCount());
        else if (Input.GetMouseButtonUp(_LMBIndex))
            StopCoroutine(_corutine);
    }

    private IEnumerator AddCount()
    {
        while (true)
        {
            _timeDelta += Time.deltaTime;
            if(_timeDelta >= _needTimeDelta)
            {
                _timeDelta = 0;
                Count++;
            }
            yield return null;
        }
    }
}

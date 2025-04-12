using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private Coroutine _corutine;
    private float _count;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _corutine = StartCoroutine(AddCount());
        else if (Input.GetMouseButtonUp(0))
            StopCoroutine(_corutine);

    }

    private IEnumerator AddCount()
    {
        yield return new WaitForSeconds(.5f);
        _count += 1;
        Debug.Log(_count);
        _corutine = StartCoroutine(AddCount());
    }
}

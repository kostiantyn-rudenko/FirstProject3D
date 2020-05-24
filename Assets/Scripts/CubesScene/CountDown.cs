using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    private int _numSeconds = 5;
    private float _counter = 0f;
    private bool _started = false;
    public void StartCount()
    {
        _started = true;
    }

    public void SetTimeCount(int time)
    {
        _numSeconds = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (_started)
        {
            var text = gameObject.GetComponent<UnityEngine.UI.Text>();
            text.text = (_numSeconds - (int)_counter).ToString();
            _counter += Time.deltaTime;
        }

        if (_counter > (float)_numSeconds)
        {
            var text = gameObject.GetComponent<UnityEngine.UI.Text>();
            text.text = (_numSeconds - (int)_counter).ToString();
            Destroy(this);
        }
    }
}

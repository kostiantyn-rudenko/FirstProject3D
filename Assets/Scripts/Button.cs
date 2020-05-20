using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Switcher))]
public class Button : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text _text;
    private bool _triggered = false;
    private int _timeBeforeBoom = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (_triggered)
            return;

        Switcher switcher = gameObject.GetComponent<Switcher>();
        if (switcher)
            switcher.Switch();

        var countdown = _text.GetComponent<CountDown>();
        countdown.SetTimeCount(5);
        countdown.StartCount();

        StartCoroutine("TriggerExplodsion");
        _triggered = true;
    }

    private IEnumerator TriggerExplodsion()
    {
        yield return new WaitForSeconds(_timeBeforeBoom);
        Explode explode = gameObject.GetComponent<Explode>();
        if (explode)
        {
            explode.Exlpode();
        }
    }
}

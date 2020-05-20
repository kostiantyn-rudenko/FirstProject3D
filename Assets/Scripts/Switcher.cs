using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    [SerializeField] private GameObject _switchOn = null;
    [SerializeField] private GameObject _switchOff = null;

    public void Switch()
    {
        _switchOff.SetActive(false);
        _switchOn.SetActive(true);
        Destroy(this);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Wheat : MonoBehaviour
{
    [SerializeField] private UnityEvent _onOutOfWheatEvent;

    [SerializeField] private int _wheatNum = 10;

    public void CheckTheWheat()
    {
        if (_wheatNum < 0)
        {
            _onOutOfWheatEvent.Invoke();
        }
    }

    public int WheatNum
    {
        get { return _wheatNum; }
        set { _wheatNum = value; }
    }
}

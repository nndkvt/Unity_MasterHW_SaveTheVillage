using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AmbushArmy : MonoBehaviour
{
    [SerializeField] private UnityEvent _onAmbushCompletedEvent;

    [SerializeField] private Warriors _warriorsObject;

    [SerializeField] private int _ambushArmyNum = 5;
    [SerializeField] private int _ambushArmyIncrease = 2;

    private int _ambushWaveNum = 1;

    public void Ambush()
    {
        _warriorsObject.UnitNum -= _ambushArmyNum;
        _ambushArmyNum += _ambushArmyIncrease;
        _ambushWaveNum++;
        _onAmbushCompletedEvent.Invoke();
    }

    public int AmbushArmyNum
    {
        get { return _ambushArmyNum; }
    }

    public int AmbushWaveNum
    {
        get { return _ambushWaveNum; }
    }
}

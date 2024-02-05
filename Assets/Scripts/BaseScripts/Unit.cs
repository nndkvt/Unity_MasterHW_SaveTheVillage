using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Unit : MonoBehaviour
{
    [SerializeField] protected UnityEvent _onOutOfUnitsEvent;

    [SerializeField] protected Wheat _wheatObject;

    [SerializeField] protected int _unitNum;
    [SerializeField] protected int _unitAffectWheat;

    public virtual void AffectWheat()
    {
        _wheatObject.WheatNum += _unitNum * _unitAffectWheat;
    }

    public virtual void CheckUnitNum()
    {
        if (_unitNum < 0)
        {
            _onOutOfUnitsEvent.Invoke();
        }
    }

    public int UnitNum
    {
        get { return _unitNum; }
        set { _unitNum = value; }
    }

    public int UnitAffectWheat
    {
        get { return _unitAffectWheat; }
        set { _unitAffectWheat = value; }
    }
}

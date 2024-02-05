using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RecruitUnits : MonoBehaviour
{
    [SerializeField] protected UnityEvent _onUnitRecruitedEvent;

    [SerializeField] protected Wheat _wheatObject;
    [SerializeField] protected Unit _unitObject;

    [SerializeField] protected int _unitRecruitNum = 1;
    [SerializeField] protected int _unitCost = 1;

    public void RecruitUnit()
    {
        if (_wheatObject.WheatNum >= _unitCost)
        {
            _wheatObject.WheatNum -= _unitCost;
            _unitObject.UnitNum += _unitRecruitNum;
            _onUnitRecruitedEvent.Invoke();
        }
    }

    public int UnitRecruitNum 
    { 
        get { return _unitRecruitNum; } 
        set { _unitRecruitNum = value; } 
    }

    public int UnitCost
    {
        get { return _unitCost; }
        set { _unitCost = value; }
    }
}

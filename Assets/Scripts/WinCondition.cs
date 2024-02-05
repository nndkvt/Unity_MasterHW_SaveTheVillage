using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinCondition : MonoBehaviour
{
    [SerializeField] private UnityEvent _onWinConditionEvent;

    [SerializeField] private int _peasantWinNum = 250;
    [SerializeField] private int _warriorWinNum = 100;
    [SerializeField] private int _wheatWinNum = 1000;

    [SerializeField] private Peasants _peasantsObject;
    [SerializeField] private Warriors _warriorsObject;
    [SerializeField] private Wheat _wheatObject;

    public void CheckForWin()
    {
        if (_warriorsObject.UnitNum >= _warriorWinNum && 
            _peasantsObject.UnitNum >= _peasantWinNum && 
            _wheatObject.WheatNum >= _wheatWinNum)
        {
            _onWinConditionEvent.Invoke();
        }
    }

    public int PeasantWinNum { get { return _peasantWinNum; } }

    public int WarriorWinNum { get { return _warriorWinNum; } }

    public int WheatWinNum { get { return _wheatWinNum; } }
}

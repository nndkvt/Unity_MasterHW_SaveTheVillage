using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinConditionDisplay : InfoDisplay
{
    [SerializeField] private WinCondition _winConditionObject;

    public override void DisplayInfo()
    {
        _infoText.text = $"Winning conditions:\n\n" +
                         $"Peasants: {_winConditionObject.PeasantWinNum}\n" +
                         $"Warriors: {_winConditionObject.WarriorWinNum}\n" +
                         $"Wheat: {_winConditionObject.WheatWinNum}";
    }
}

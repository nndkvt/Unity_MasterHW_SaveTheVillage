using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecruitDisplay : InfoDisplay
{
    [SerializeField] private RecruitPeasants _recruitPeasantsObject;
    [SerializeField] private RecruitWarriors _recruitWarriorsObject;

    public override void DisplayInfo()
    {
        _infoText.text = $"Peasant price: {_recruitPeasantsObject.UnitCost} wh.\n" +
                         $"Warrior price: {_recruitWarriorsObject.UnitCost} wh.\n\n" +
                         $"Peasant recruit: {_recruitPeasantsObject.UnitRecruitNum} units\n" +
                         $"Warrior recruit: {_recruitWarriorsObject.UnitRecruitNum} units";
    }
}

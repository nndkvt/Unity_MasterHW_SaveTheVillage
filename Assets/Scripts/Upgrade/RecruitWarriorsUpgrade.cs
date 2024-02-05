using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitWarriorsUpgrade : Upgrade
{
    [SerializeField] private RecruitWarriors _recruitWarriorsUpgrade;

    [SerializeField] private int _warriorRecruitNumUpgrade = 1;

    public override void ApplyUpgrade()
    {
        if (_wheatObject.WheatNum >= _upgradePriceWheat && _peasantsObject.UnitNum >= _upgradePricePeasant)
        {
            _wheatObject.WheatNum -= _upgradePriceWheat;
            _peasantsObject.UnitNum -= _upgradePricePeasant;
            _recruitWarriorsUpgrade.UnitRecruitNum += _warriorRecruitNumUpgrade;
            _onUpgradeAppliedEvent.Invoke();
        }
    }
}

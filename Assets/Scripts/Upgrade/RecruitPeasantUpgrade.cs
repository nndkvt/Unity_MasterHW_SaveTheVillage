using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecruitPeasantUpgrade : Upgrade
{
    [SerializeField] private RecruitPeasants _recruitPeasantsObject;

    [SerializeField] private int _peasantRecruitNumUpgrade = 1;

    public override void ApplyUpgrade()
    {
        if (_wheatObject.WheatNum >= _upgradePriceWheat && _peasantsObject.UnitNum >= _upgradePricePeasant)
        {
            _wheatObject.WheatNum -= _upgradePriceWheat;
            _peasantsObject.UnitNum -= _upgradePricePeasant;
            _recruitPeasantsObject.UnitRecruitNum += _peasantRecruitNumUpgrade;
            _onUpgradeAppliedEvent.Invoke();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatWheatUpgrade : Upgrade
{
    [SerializeField] private Warriors _warriorsObject;

    [SerializeField] private int _eatWheatUpgrade = 1;

    public override void ApplyUpgrade()
    {
        if (_wheatObject.WheatNum >= _upgradePriceWheat && _peasantsObject.UnitNum >= _upgradePricePeasant)
        {
            _wheatObject.WheatNum -= _upgradePriceWheat;
            _peasantsObject.UnitNum -= _upgradePricePeasant;
            _warriorsObject.UnitAffectWheat -= _eatWheatUpgrade;
            _onUpgradeAppliedEvent.Invoke();
        }
    }
}

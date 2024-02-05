using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWheatUpgrade : Upgrade
{
    [SerializeField] private int _collectWheatUpgrade = 1;

    public override void ApplyUpgrade()
    {
        if (_wheatObject.WheatNum >= _upgradePriceWheat && _peasantsObject.UnitNum >= _upgradePricePeasant)
        {
            _wheatObject.WheatNum -= _upgradePriceWheat;
            _peasantsObject.UnitNum -= _upgradePricePeasant;
            _peasantsObject.UnitAffectWheat += _collectWheatUpgrade;
            _onUpgradeAppliedEvent.Invoke();
        }
    }
}

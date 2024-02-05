using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Upgrade : MonoBehaviour
{
    [SerializeField] protected UnityEvent _onUpgradeAppliedEvent;

    [SerializeField] protected int _upgradePriceWheat = 250;
    [SerializeField] protected int _upgradePricePeasant = 25;

    [SerializeField] protected Wheat _wheatObject;
    [SerializeField] protected Peasants _peasantsObject;

    public virtual void ApplyUpgrade()
    {
        // Put upgrade here
    }
}

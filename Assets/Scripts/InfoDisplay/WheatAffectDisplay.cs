using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatAffectDisplay : InfoDisplay
{
    [SerializeField] private Peasants _peasantsObject;
    [SerializeField] private Warriors _warriorsObject;

    public override void DisplayInfo()
    {
        _infoText.text = $"Peasant collect: {_peasantsObject.UnitAffectWheat} wh.\n" +
                         $"Warriors eat: {_warriorsObject.UnitAffectWheat} wh.\n\n";
    }
}

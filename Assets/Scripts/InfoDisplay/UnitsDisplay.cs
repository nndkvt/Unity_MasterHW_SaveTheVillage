using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitsDisplay : InfoDisplay
{
    [SerializeField] private Peasants _peasantsObject;
    [SerializeField] private Warriors _warriorsObject;
    [SerializeField] private Wheat _wheatObject;

    public override void DisplayInfo()
    {
        _infoText.text = $"Peasants: {_peasantsObject.UnitNum}\n" +
                         $"Warriors: {_warriorsObject.UnitNum}\n\n" +
                         $"Wheat: {_wheatObject.WheatNum}";
    }
}

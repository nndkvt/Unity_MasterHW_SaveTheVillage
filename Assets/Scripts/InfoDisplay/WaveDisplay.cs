using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveDisplay : InfoDisplay
{
    [SerializeField] private AmbushArmy _ambushArmyObject;

    public override void DisplayInfo()
    {
        _infoText.text = $"Wave: {_ambushArmyObject.AmbushWaveNum}\n\n" +
                         $"Ambush army: {_ambushArmyObject.AmbushArmyNum}";
    }
}

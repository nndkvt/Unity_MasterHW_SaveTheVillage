using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Warriors : Unit
{
    // Солдаты едят пшеницу, поэтому меняем += на -=
    public override void AffectWheat()
    {
        _wheatObject.WheatNum -= _unitNum * _unitAffectWheat;
    }
}

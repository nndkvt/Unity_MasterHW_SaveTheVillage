using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Warriors : Unit
{
    // ������� ���� �������, ������� ������ += �� -=
    public override void AffectWheat()
    {
        _wheatObject.WheatNum -= _unitNum * _unitAffectWheat;
    }
}

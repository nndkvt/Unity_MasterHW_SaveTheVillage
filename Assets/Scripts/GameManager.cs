using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent _onGameStartEvent;

    private void Start()
    {
        _onGameStartEvent.Invoke();
    }

    //private void DisplayInfo()
    //{
    //    _infoDisplay.text = $"Peasants: {_peasantNum}\n" +
    //                        $"Warriors: {_warriorNum}\n\n" +
    //                        $"Wheat: {_wheatNum}";
    //}

    //private void DisplayWave()
    //{
    //    _waveDisplay.text = $"Wave: {_waveNum}\n\n" +
    //                        $"Ambush army: {_ambushArmyNum}";
    //}

    //private void DisplayPrice()
    //{
    //    _priceDisplay.text = $"Peasant price: {_peasantCost} wh.\n" +
    //                        $"Warrior price: {_warriorCost} wh.\n\n" +
    //                        //$"Peasant collect: {_peasantCollectWheat} wh.\n" +
    //                        //$"Warrior eat: {_warriorEatWheat} wh.\n\n" +
    //                        $"Peasant recruit: {_peasantRecruitNum} units\n" +
    //                        $"Warrior recruit: {_warriorRecruitNum} units\n\n";
    //                        //$"Upgrades price: {_upgradePriceWheat} wh. + {_upgradePricePeasant} peasants";
    //}

    //private void DisplayWinCond()
    //{
    //    _winningConditionDisplay.text = $"Winning conditions:\n\n" +
    //                                    $"Peasants: {_peasantWinNum}\n" +
    //                                    $"Warriors: {_warriorWinNum}\n" +
    //                                    $"Wheat: {_wheatWinNum}";
    //}

    //public void RecruitPeasant()
    //{
    //    if (_wheatNum >= _peasantCost)
    //    {
    //        _wheatNum -= _peasantCost;
    //        _peasantNum += _peasantRecruitNum;
    //        DisplayInfo();
    //        CheckUnits();
    //    }
    //}

    //public void RecruitWarrior()
    //{
    //    if (_wheatNum >= _warriorCost)
    //    {
    //        _wheatNum -= _warriorCost;
    //        _warriorNum += _warriorRecruitNum;
    //        DisplayInfo();
    //        CheckUnits();
    //    }
    //}

    //public void HarvestWheat()
    //{
    //    _wheatNum += _peasantNum * _peasantCollectWheat;
    //    DisplayInfo();
    //    CheckUnits();
    //}

    //public void FeedingTime()
    //{
    //    _wheatNum -= _warriorNum * _warriorEatWheat;
    //    DisplayInfo();
    //    CheckTheWheat();
    //}

    //public void UpgradeWheatCollect()
    //{
    //    if (_wheatNum >= _upgradePriceWheat && _peasantNum >= _upgradePricePeasant)
    //    {
    //        _wheatNum -= _upgradePriceWheat;
    //        _peasantNum -= _upgradePricePeasant;
    //        _peasantCollectWheat += _collectWheatUpgrade;
    //        DisplayInfo();
    //        DisplayPrice();
    //    }
    //}

    //public void UpgradeWheatEat()
    //{
    //    if (_wheatNum >= _upgradePriceWheat && _peasantNum >= _upgradePricePeasant)
    //    {
    //        _wheatNum -= _upgradePriceWheat;
    //        _peasantNum -= _upgradePricePeasant;
    //        _warriorEatWheat -= _eatWheatUpgrade;
    //        DisplayInfo();
    //        DisplayPrice();
    //    }
    //}

    //public void UpgradeRecruitPeasant()
    //{
    //    if (_wheatNum >= _upgradePriceWheat && _peasantNum >= _upgradePricePeasant)
    //    {
    //        _wheatNum -= _upgradePriceWheat;
    //        _peasantNum -= _upgradePricePeasant;
    //        _peasantRecruitNum += _peasantRecruitNumUpgrade;
    //        DisplayInfo();
    //        DisplayPrice();
    //    }
    //}

    //public void UpgradeRecruitWarrior()
    //{
    //    if (_wheatNum >= _upgradePriceWheat && _peasantNum >= _upgradePricePeasant)
    //    {
    //        _wheatNum -= _upgradePriceWheat;
    //        _peasantNum -= _upgradePricePeasant;
    //        _warriorRecruitNum += _warriorRecruitNumUpgrade;
    //        DisplayInfo();
    //        DisplayPrice();
    //    }
    //}

    //public void Ambush()
    //{
    //    _warriorNum -= _ambushArmyNum;
    //    _ambushArmyNum += _ambushArmyIncrease;
    //    _waveNum++;
    //    DisplayInfo();
    //    DisplayWave();
    //    CheckWarriors();
    //}

    //private void CheckTheWheat()
    //{
    //    if (_wheatNum < 0)
    //    {
    //        Time.timeScale = 0;
    //        _outOfWheatWindow.SetActive(true);
    //    }
    //}

    //private void CheckWarriors()
    //{
    //    if (_warriorNum < 0)
    //    {
    //        Time.timeScale = 0;
    //        _outOfWarriorsWindow.SetActive(true);
    //    }
    //}
}

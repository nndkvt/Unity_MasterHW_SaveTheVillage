using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource _bgMusic;
    [SerializeField] private AudioSource _peasantRecruitedSound;
    [SerializeField] private AudioSource _warriorRecruitedSound;
    [SerializeField] private AudioSource _peasantCollectWheatSound;
    [SerializeField] private AudioSource _warriorEatWheatSound;
    [SerializeField] private AudioSource _ambushSound;

    [SerializeField] private AudioClip[] _peasantClips;

    public void PlayPauseBGM()
    {
        if (_bgMusic.isPlaying)
        {
            _bgMusic.Pause();
        }
        else
        {
            _bgMusic.Play();
        }
    }

    public void CollectWheatSound()
    {
        _peasantCollectWheatSound.Play();
    }

    public void EatWheatSound()
    {
        _warriorEatWheatSound.Play();
    }

    public void AmbushSound()
    {
        _ambushSound.Play();
    }

    public void WarriorRecruitSound()
    {
        _warriorRecruitedSound.Play();
    }

    public void PeasantRecruitSound()
    {
        CallRandomAudio();
    }

    private void CallRandomAudio()
    {
        _peasantRecruitedSound.clip = _peasantClips[Random.Range(0, _peasantClips.Length)];
        _peasantRecruitedSound.Play();
    }
}

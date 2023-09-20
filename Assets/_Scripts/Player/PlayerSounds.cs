using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip AudioClipPowerUp;

    public AudioClip AudioClipMonster;

    public AudioClip AudioClipDie;

    private void Awake()
    {
      audioSource = GetComponent<AudioSource>();
    }

    public void PlayerCollectPowerUp()
    {
        PLayClip(AudioClipPowerUp);
    }   

    public void PlayerDie()
    {
        PLayClip(AudioClipDie);
    }

    public void PlayerHitMonster()
    {
        PLayClip(AudioClipMonster);
    }

    private void PLayClip(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;  
        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXManager : MonoBehaviour
{
    public AudioClip playerShoot1;
    public AudioClip playerShoot2;
    public AudioClip asteroidExplosion;
    public AudioClip playerDamage;
    public AudioClip playerExplosion;
    public AudioClip BgMusicGameplay;
    public AudioClip BgMusicTitleScreen;
    

    private AudioSource SFXaudioSource;
    private AudioClip[] playerShoots = new AudioClip[2];
    private AudioSource BgMusicAudioSource;
    
    public void Awake()
    {
        SFXaudioSource = GetComponent<AudioSource>();
        //GameObject child = this.transform.Find("BgMusic").gameObject;
        BgMusicAudioSource = gameObject.transform.Find("BgMusic").gameObject.GetComponent<AudioSource>();
        //BgMusicAudioSource.GetComponent<AudioSource>().Play();
        playerShoots[0] = playerShoot1;
        playerShoots[1] = playerShoot2;



               
    }



    //called in the PlayerController Script
    public void PlayerShoot()
    {

        int randomIndex = Random.Range(0, playerShoots.Length);
        SFXaudioSource.PlayOneShot(playerShoots[randomIndex]);

    }

    //called in the PlayerController Script
    public void PlayerDamage()
    {
        SFXaudioSource.PlayOneShot(playerDamage);
    }

    //called in the PlayerController Script
    public void PlayerExplosion()
    {
        SFXaudioSource.PlayOneShot(playerExplosion);
    }

    //called in the AsteroidDestroy script
    public void AsteroidExplosion()
    {
        SFXaudioSource.PlayOneShot(asteroidExplosion);
    }

    
    public void BGMusicMainMenu()
    {
        BgMusicAudioSource.clip = BgMusicTitleScreen;
        BgMusicAudioSource.Play();
    }

    public void BGMusicGameplay()
    {
        BgMusicAudioSource.GetComponent<AudioSource>().clip = BgMusicGameplay;
        BgMusicAudioSource.Play();

    }
}

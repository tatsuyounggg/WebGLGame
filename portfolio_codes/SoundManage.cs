using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManage : MonoBehaviour
{
  public bool DontDestroyEnabled = true;
  private AudioSource audioSource;
  public AudioClip soundClick;
  public AudioClip soundCorrect;
  public AudioClip soundBad;
  public AudioClip soundJump;
  public AudioClip soundClear;

    // Start is called before the first frame update
    void Start()
    {
      if (DontDestroyEnabled) {
        DontDestroyOnLoad (this);
      }
      this.audioSource = GetComponent<AudioSource>();
      if(SceneManager.GetActiveScene().name == "PreScene"){
        SceneManager.LoadScene ("TitleScene");
      }
      this.audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SoundClick(){
      audioSource.PlayOneShot(soundClick);
    }
    public void SoundCorrect(){
      audioSource.PlayOneShot(soundCorrect);
    }
    public void SoundBad(){
      audioSource.PlayOneShot(soundBad);
    }
    public void SoundJump(){
      audioSource.PlayOneShot(soundJump);
    }
    public void SoundClear(){
      audioSource.PlayOneShot(soundClear);
    }
}

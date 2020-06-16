using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCheck : MonoBehaviour
{
    public static bool one = true;
    private Animator anim;
    SoundManage audioSource;


    // Start is called before the first frame update
    void Start()
    {
      anim = GameObject.Find("player").GetComponent<Animator>();
      audioSource = GameObject.Find("SoundManage").GetComponent<SoundManage>();

    }

    private void OnTriggerEnter2D(Collider2D collider){
    if(collider.tag == "bad"){
          GameObject refObj = GameObject.Find("CloudFactory");
          CloudFactory cf = refObj.GetComponent<CloudFactory>();
          cf.DestroyCloud();
          Player.ySpeed = -15.0f;
          Player.isJump = false;
          anim.SetBool("jump",false);
          anim.SetBool("run",false);
          anim.SetBool("down",true);
          audioSource.SoundBad();
    }
    if(collider.tag == "correct"){
      if(one){
      GameObject obj = collider.gameObject;
      Destroy(obj);
      GameDirector.next = true;
      one = false;
      audioSource.SoundCorrect();
    }
  }
}
}

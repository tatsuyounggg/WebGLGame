using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundCheck : MonoBehaviour
{
   private bool isGround = false;
   private bool isGroundEnter,isGroundStay,isGroundExit;
   private Animator anim;
   private int player_layer;
   private int ground_floor_layer;

    // Start is called before the first frame update
    void Start()
    {
      anim = GameObject.Find("player").GetComponent<Animator>();
      player_layer = LayerMask.NameToLayer("Player");
      ground_floor_layer = LayerMask.NameToLayer("GroundFloor");
    }

    // Update is called once per frame
    public bool IsGround(){
      if(isGroundEnter || isGroundStay){
        isGround = true;
      }
      else if(isGroundExit){
        isGround = false;
      }
      isGroundEnter = false;
      isGroundStay = false;
      isGroundExit = false;
      return isGround;
    }

    private void OnTriggerEnter2D(Collider2D collider){
      if(collider.tag == "cloud" ){
        if (SceneManager.GetActiveScene().name == "GameScene") {
        isGroundEnter = true;
      }
      else if(SceneManager.GetActiveScene().name == "TitleScene" ){
        isGroundEnter = true;
        GameObject refObj = GameObject.Find("CloudFactory");
        CloudFactoryT cf = refObj.GetComponent<CloudFactoryT>();
        cf.MakeGround(collider);
      }
}
      else if(collider.tag == "ground"){
        if (SceneManager.GetActiveScene().name == "GameScene") {
          // Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer, false);
          anim.SetBool("down",false);
        isGroundEnter = true;
        GameObject refObj = GameObject.Find("CloudFactory");
        CloudFactory cf = refObj.GetComponent<CloudFactory>();
        cf.DestroyCloud();
        cf.MakeChoice(collider);
    }

    else if(SceneManager.GetActiveScene().name == "TitleScene" ){
      // Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer, false);
      isGroundEnter = true;
      GameObject refObj = GameObject.Find("CloudFactory");
      CloudFactoryT cf = refObj.GetComponent<CloudFactoryT>();
      cf.DestroyCloud();
      cf.MakeChoice(collider);
    }
    }

    else if(collider.tag == "choice"){
        if (SceneManager.GetActiveScene().name == "GameScene") {
      isGroundEnter = true;
      GameObject refObj = GameObject.Find("CloudFactory");
      CloudFactory cf = refObj.GetComponent<CloudFactory>();
      cf.MakeCloud(collider);
    }
    else if(SceneManager.GetActiveScene().name == "TitleScene") {
      isGroundEnter = true;
      GameObject refObj = GameObject.Find("CloudFactory");
      CloudFactoryT cf = refObj.GetComponent<CloudFactoryT>();
      cf.MakeCloud(collider);
    }

  }
}
    private void OnTriggerStay2D(Collider2D collider){
      isGroundStay = true;
    }

    private void OnTriggerExit2D(Collider2D collider){
      isGroundExit = true;
   }
  }

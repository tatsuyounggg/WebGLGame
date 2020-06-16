using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float speed;
   public float gravity;
   public float jumpSpeed;
   public float jumpHeight;
   // public float jumpLimitTime;
   float xSpeed = 0.0f;
   public static float ySpeed;
   public GroundCheck ground;
   // public GroundCheck head;

   private Animator anim = null;
   private Rigidbody2D rb = null;
   private bool isGround = false;
   public static bool isJump = false;
   private float jumpPos = 0.0f;
   // private float jumpTime = 0.0f;
   SoundManage audioSource;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = GameObject.Find("SoundManage").GetComponent<SoundManage>();
    }

    // Update is called once per frame
void Update(){
  // bool canTime = jumpLimitTime > jumpTime;
  bool canHeight = jumpPos + jumpHeight > transform.position.y;
  if(isGround){
  if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)){
    ySpeed = jumpSpeed;
    jumpPos = transform.position.y;
    isJump = true;
    audioSource.SoundJump();
  }
}
if (Input.GetKeyDown(KeyCode.DownArrow)) {
int cloud_floor_layer = LayerMask.NameToLayer("CloudFloor");
if (Physics2D.Raycast(transform.position, -transform.up,cloud_floor_layer)) {
  int player_layer = LayerMask.NameToLayer("Player");
  Physics2D.IgnoreLayerCollision(player_layer, cloud_floor_layer);
  isJump = false;
}
int choice_floor_layer = LayerMask.NameToLayer("ChoiceFloor");
if(Physics2D.Raycast(transform.position, -transform.up, choice_floor_layer)) {
  int player_layer = LayerMask.NameToLayer("Player");
  Physics2D.IgnoreLayerCollision(player_layer, choice_floor_layer);
  isJump = false;
}
}
if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.Space)){
  jumpPos = transform.position.y;
  ySpeed = -gravity;
  isJump = false;
}
if(!canHeight){
  ySpeed = -gravity;
  isJump = false;
}
}

    void FixedUpdate()
    {

      isGround = ground.IsGround();

        // isHead = head.IsGround();
        // lastY = transform.position.y;
        float horizontalKey = Input.GetAxis("Horizontal");
        // float verticallKey = Input.GetAxis("Vertical");
      if(isGround){
        if(horizontalKey > 0){
          transform. localScale = new Vector3(-1,1,1);
          anim.SetBool("run",true);
          xSpeed = speed;
        }
        else if(horizontalKey < 0){
          transform. localScale = new Vector3(1,1,1);
          anim.SetBool("run",true);
          xSpeed = -speed;
        }
        else{
          anim.SetBool("run",false);
          xSpeed = 0.0f;
        }
      }
      else {
        if(horizontalKey > 0){
          transform. localScale = new Vector3(-1,1,1);
          // anim.SetBool("run",true);
          xSpeed = speed / 2;
        }
        else if(horizontalKey < 0){
          transform. localScale = new Vector3(1,1,1);
          // anim.SetBool("run",true);
          xSpeed = -speed / 2;
        }
        else{
          // anim.SetBool("run",false);
          xSpeed = 0.0f;
        }
      }
        anim.SetBool("jump", isJump);
        anim.SetBool("ground", isGround);
        rb.velocity = new Vector2(xSpeed,ySpeed);
    }
}

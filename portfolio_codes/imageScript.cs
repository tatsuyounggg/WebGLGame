using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageScript : MonoBehaviour
{
  [SerializeField]
  private RectTransform canvasRectTfm;
  [SerializeField]
  private Transform targetTfm;

  private RectTransform myRectTfm;
  private Text bubble;
  private float count;
  private Vector3 offset = new Vector3(-4.0f,0.0f,0);

  void Start() {
      myRectTfm = GetComponent<RectTransform>();
      this.bubble = this.GetComponent<Text>();
      this.bubble.text = "スタートボタンをおして〜";
  }

  void Update() {
     count += Time.deltaTime;
     if(count > 2.0f){
       this.bubble.text = "→←で動くよ〜";
     }
     if(count > 4.0f){
       this.bubble.text = "↑かスペースキーでジャンプ！";
     }
     if(count > 6.0f){
       this.bubble.text = "どこまで高く行けるかな〜";
     }
     if(count > 8.0f){
       this.bubble.text = "せいかいだとおもうくもにのるんだよ";
     }
     if(count > 10.0f){
       this.bubble.text = "きょうもがんばろ〜";
     }
     if(count > 12.0f){
       this.bubble.text = "下でくもをおりられるよ〜";
     }
     if(count > 14.0f){
       this.bubble.text = "スタートボタンをおして〜";
       count = 0.0f;
     }
      if(targetTfm.position.x > 0.0f){
        offset = new Vector3(-4.0f,0.0f,0);
      }
      else if(targetTfm.position.x < 0.0f){
        offset = new Vector3(4.0f,0.0f,0);
      }
      Vector2 screenPos = RectTransformUtility.WorldToScreenPoint(Camera.main, targetTfm.position + offset);

      myRectTfm.position = screenPos;

  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneManage : MonoBehaviour
{
  private bool firstPush = false;
  private bool firstSelect = false;
  GameObject canvas;
  GameObject selectCanvas;
  GameObject startButton;
  SoundManage audioSource;

   // Start is called before the first frame update
   void Start()
   {
     if (SceneManager.GetActiveScene().name == "SelectScene" ||  SceneManager.GetActiveScene().name == "SelectSceneH") {
       canvas = GameObject.Find("Canvas");
       canvas.SetActive (true);
       startButton = GameObject.Find("StartButton");
       startButton.SetActive (false);
       selectCanvas = GameObject.Find("SelectCanvas");
       selectCanvas.SetActive (false);

     }
     audioSource = GameObject.Find("SoundManage").GetComponent<SoundManage>();
   }
   // Update is called once per frame
   void Update()
   {

   }
   public void GoTitle(){
     if(!firstPush){
       SceneManager.LoadScene ("TitleScene");
       audioSource.SoundClick();
       firstPush = true;
     }
   }
   public void GoSelect(){
     if(!firstPush){
       SceneManager.LoadScene ("SelectScene");
       audioSource.SoundClick();
       firstPush = true;
     }
   }

   public void Select1(){
     if(!firstSelect){
   GameDirector.multiplied = 1;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
   }
   public void Select2(){
     if(!firstSelect){
   GameDirector.multiplied = 2;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
   }
   public void Select3(){
     if(!firstSelect){
   GameDirector.multiplied = 3;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select4(){
     if(!firstSelect){
   GameDirector.multiplied = 4;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select5(){
     if(!firstSelect){
   GameDirector.multiplied = 5;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select6(){
     if(!firstSelect){
   GameDirector.multiplied = 6;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select7(){
     if(!firstSelect){
   GameDirector.multiplied = 7;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select8(){
     if(!firstSelect){
   GameDirector.multiplied = 8;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select9(){
     if(!firstSelect){
   GameDirector.multiplied = 9;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select19Random(){
     if(!firstSelect){
   GameDirector.select = "19Random";
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   GameObject topbutton = GameObject.Find("TopButton");
   GameObject underbutton = GameObject.Find("UnderButton");
   GameObject randombutton = GameObject.Find("RandomButton");
   topbutton.SetActive(false);
   underbutton.SetActive(false);
   randombutton.SetActive(false);
   startButton.SetActive (true);
   firstSelect = true;
   }
 }
   public void SelectHard(){
     if(!firstPush){
       SceneManager.LoadScene ("SelectSceneH");
       audioSource.SoundClick();
       firstPush = true;
     }
 }
   public void Select10(){
     if(!firstSelect){
   GameDirector.multiplied = 10;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
   }
   public void Select11(){
     if(!firstSelect){
   GameDirector.multiplied = 11;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
   }
   public void Select12(){
     if(!firstSelect){
   GameDirector.multiplied = 12;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select13(){
     if(!firstSelect){
   GameDirector.multiplied = 13;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select14(){
     if(!firstSelect){
   GameDirector.multiplied = 14;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select15(){
     if(!firstSelect){
   GameDirector.multiplied = 15;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select16(){
     if(!firstSelect){
   GameDirector.multiplied = 16;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select17(){
     if(!firstSelect){
   GameDirector.multiplied = 17;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select18(){
     if(!firstSelect){
   GameDirector.multiplied = 18;
   audioSource.SoundClick();
   canvas.SetActive (false);
   selectCanvas.SetActive (true);
   firstSelect = true;
   }
 }
   public void Select19(){
     if(!firstSelect){
       GameDirector.multiplied = 19;
       audioSource.SoundClick();
       canvas.SetActive (false);
       selectCanvas.SetActive (true);
       firstSelect = true;
   }
 }
   public void Select1119Random(){
     if(!firstSelect){
       GameDirector.select = "1119Random";
       audioSource.SoundClick();
       canvas.SetActive (false);
       selectCanvas.SetActive (true);
       GameObject topbutton = GameObject.Find("TopButton");
       GameObject underbutton = GameObject.Find("UnderButton");
       GameObject randombutton = GameObject.Find("RandomButton");
       topbutton.SetActive(false);
       underbutton.SetActive(false);
       randombutton.SetActive(false);
       startButton.SetActive (true);
       firstSelect = true;
   }
 }

   public void PressTop(){
     if(!firstPush){
       GameDirector.select = "Top";
       audioSource.SoundClick();
       SceneManager.LoadScene ("GameScene");
       firstPush = true;
     }
   }
   public void PressBottom(){
     if(!firstPush){
       GameDirector.select = "Bottom";
       audioSource.SoundClick();
       SceneManager.LoadScene ("GameScene");
       firstPush = true;
     }
   }
   public void PressRandom(){
     if(!firstPush){
       GameDirector.select = "Random";
       audioSource.SoundClick();
       SceneManager.LoadScene ("GameScene");
       firstPush = true;
     }
   }
   public void PressStart(){
     if(!firstPush){
       audioSource.SoundClick();
       SceneManager.LoadScene ("GameScene");
       firstPush = true;
     }
   }
}

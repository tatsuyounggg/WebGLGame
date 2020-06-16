using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
   public GameObject BadTrigger;
   GameObject question;
   GameObject choice1;
   GameObject choice2;
   GameObject choice3;
   GameObject player;
   GameObject refObj;
   CloudFactory cf;
   SoundManage audioSource;
   public static bool next;
   public static bool One;
   public static bool Qn;
   public static string select = "Top";
   // public enum Course {Top, Bottom, Random};
   public static int clear = 9;
   public static int multiplied = 2;
   List<GameObject> list_trigger = new List<GameObject>();
   int[] ary;
   int[] cho;
   int rnd;
   int answer;
   int qN;
   // int seed = System.Environment.TickCount;

   void nextQuestion(){
     switch(select)
     {
       case "Top":
       qN++;
       rnd = qN;
       answer = multiplied * qN;
       ary = new int[] {answer + multiplied,answer - multiplied,
         answer + 2 * multiplied, answer - 2 * multiplied};
       for(int i = 0;i < ary.Length;i++){
         if(ary[i] == 0){
           ary[i] += 4 * multiplied;
         }
         else if(ary[i] < 0){
           ary[i] += 5 * multiplied;
         }
       }
       randomArray(ary);
       cho = new int[] { answer,ary[0],ary[1]};
       randomArray(cho);
       this.question.GetComponent<Text>().text = "だい "+ qN + " もん";
       makeBad(cho);
       break;

       case "Bottom":
       qN++;
       rnd = 10 - qN;
       answer = multiplied * rnd;
       ary = new int[] {answer + multiplied,answer - multiplied,
         answer + 2 * multiplied, answer - 2 * multiplied};
       for(int i = 0;i < ary.Length;i++){
         if(ary[i] == 0){
           ary[i] += 4 * multiplied;
         }
         else if(ary[i] < 0){
           ary[i] += 5 * multiplied;
         }
       }
       randomArray(ary);
       cho = new int[] { answer,ary[0],ary[1]};
       randomArray(cho);
       this.question.GetComponent<Text>().text = "だい "+ qN + " もん";
       makeBad(cho);
       break;

       case "Random":
       rnd = Random.Range(1,10);
       answer = multiplied * rnd;
       ary = new int[] {answer + multiplied,answer - multiplied,
         answer + 2 * multiplied, answer - 2 * multiplied};
       for(int i = 0;i < ary.Length;i++){
         if(ary[i] == 0){
           ary[i] += 4 * multiplied;
         }
         else if(ary[i] < 0){
           ary[i] += 5 * multiplied;
         }
       }
       randomArray(ary);
       cho = new int[] { answer,ary[0],ary[1]};
       randomArray(cho);
       qN += 1;
       this.question.GetComponent<Text>().text = "だい "+ qN + " もん";
       makeBad(cho);
       break;

       case "19Random":
       rnd = Random.Range(1,10);
       multiplied = Random.Range(1,10);
       answer = multiplied * rnd;
       ary = new int[] {answer + multiplied,answer - multiplied,
         answer + 2 * multiplied, answer - 2 * multiplied};
       for(int i = 0;i < ary.Length;i++){
         if(ary[i] == 0){
           ary[i] += 4 * multiplied;
         }
         else if(ary[i] < 0){
           ary[i] += 5 * multiplied;
         }
       }
       randomArray(ary);
       cho = new int[] { answer,ary[0],ary[1]};
       randomArray(cho);
       qN += 1;
       this.question.GetComponent<Text>().text = "だい "+ qN + " もん";
       makeBad(cho);
       break;

       case "1119Random":
       rnd = Random.Range(1,10);
       multiplied = Random.Range(11,20);
       answer = multiplied * rnd;
       ary = new int[] {answer + multiplied,answer - multiplied,
         answer + 2 * multiplied, answer - 2 * multiplied};
       for(int i = 0;i < ary.Length;i++){
         if(ary[i] == 0){
           ary[i] += 4 * multiplied;
         }
         else if(ary[i] < 0){
           ary[i] += 5 * multiplied;
         }
       }
       randomArray(ary);
       cho = new int[] { answer,ary[0],ary[1]};
       randomArray(cho);
       qN += 1;
       this.question.GetComponent<Text>().text = "だい "+ qN + " もん";
       makeBad(cho);
       break;
     }
  }

  void DelayMethod(){
    this.question.GetComponent<Text>().text = multiplied + " × " + rnd + " = ??";
    this.choice1.GetComponent<Text>().text = cho[0].ToString();
    this.choice2.GetComponent<Text>().text = cho[1].ToString();
    this.choice3.GetComponent<Text>().text = cho[2].ToString();
    HeadCheck.one = true;
  }
    // Start is called before the first frame update
    void Start()
    {
        One = true;
        Qn = true;
        next = false;
        refObj = GameObject.Find("CloudFactory");
        cf = refObj.GetComponent<CloudFactory>();
        this.question = GameObject.Find("Question");
        this.choice1 = GameObject.Find("Choice1");
        this.choice2 = GameObject.Find("Choice2");
        this.choice3 = GameObject.Find("Choice3");
        this.player = GameObject.Find("player");
        audioSource = GameObject.Find("SoundManage").GetComponent<SoundManage>();

    }

    // Update is called once per frame
    void Update()
    {
      if(next){
        nextQuestion();
        if(clear < qN){
          if(select == "19Random" || multiplied <= 9){
            SceneManager.LoadScene ("SelectScene");
          }
          else {
            SceneManager.LoadScene ("SelectSceneH");
          }
            audioSource.SoundClear();
            HeadCheck.one = true;
        }
        Invoke("DelayMethod", 0.8f);
        next = false;
      }
      }

  static void randomArray(int[] arr){
    System.Random rng = new System.Random();
    int n = arr.Length;
    while (n > 1)
 {
  n--;
  int k = rng.Next(n + 1);
  int tmp = arr[k];
  arr[k] = arr[n];
  arr[n] = tmp;
}
  }

  void makeBad(int[] ary){
  if(ary[0] == answer){
  DestroyTrigger();
  GameObject newobj = Instantiate(BadTrigger) as GameObject;
  newobj.transform.position = new Vector3(0.0f, player.transform.position.y + 12.6f,0.0f);
  GameObject newobj2 = Instantiate(BadTrigger) as GameObject;
  newobj2.transform.position = new Vector3(6.7f, player.transform.position.y + 12.6f,0.0f);
  list_trigger.Add(newobj);
  list_trigger.Add(newobj2);
  }
  else if(ary[1] == answer){
    DestroyTrigger();
    GameObject newobj = Instantiate(BadTrigger) as GameObject;
    newobj.transform.position = new Vector3(-6.7f, player.transform.position.y + 12.6f,0.0f);
    GameObject newobj2 = Instantiate(BadTrigger) as GameObject;
    newobj2.transform.position = new Vector3(6.7f, player.transform.position.y + 12.6f,0.0f);
    list_trigger.Add(newobj);
    list_trigger.Add(newobj2);
  }
  else{
    DestroyTrigger();
    GameObject newobj = Instantiate(BadTrigger) as GameObject;
    newobj.transform.position = new Vector3(-6.7f, player.transform.position.y + 12.6f,0.0f);
    GameObject newobj2 = Instantiate(BadTrigger) as GameObject;
    newobj2.transform.position = new Vector3(0.0f, player.transform.position.y + 12.6f,0.0f);
    list_trigger.Add(newobj);
    list_trigger.Add(newobj2);
  }
}
  void DestroyTrigger(){
  for(int i = 0; i < list_trigger.Count; i++){
  Destroy(list_trigger[i]);
}
}
  }

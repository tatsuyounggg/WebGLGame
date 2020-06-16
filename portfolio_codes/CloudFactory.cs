using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudFactory : MonoBehaviour
{
      public GameObject cloudPrefab;
      public GameObject groundPrefab;
      public GameObject choicePrefab;
      GameObject obj;
      GameObject player;
      List<GameObject> list_cloud = new List<GameObject>();

    void Start()
    {
        this.player = GameObject.Find("player");
        MakeGround();
    }

    public void MakeCloud(Collider2D collider){
      GameObject newobj = Instantiate(cloudPrefab) as GameObject;
      obj = collider.gameObject;
      newobj.transform.position = new Vector3(obj.transform.position.x,obj.transform.position.y + 4.7f,0);
      list_cloud.Add(newobj);

    }

    public void MakeChoice(Collider2D collider){
      obj = collider.gameObject;
      for(int i = 0; i <=12; i+=6){
      GameObject newobj = Instantiate(choicePrefab) as GameObject;
      newobj.transform.position = new Vector3(-6.0f + i,obj.transform.position.y + 5.0f,0.0f);
      list_cloud.Add(newobj);
    }
    }

    public void DestroyCloud(){
      for(int i = 0; i < list_cloud.Count; i++){
      Destroy(list_cloud[i]);
    }
    }
    void MakeGround(){
     for(int i = 0; i < GameDirector.clear + 1; i++){
      GameObject newobj = Instantiate(groundPrefab) as GameObject;
      newobj.transform.position = new Vector3(0.0f, -5.0f + i*14.5f ,0.0f);
     }
   }
}

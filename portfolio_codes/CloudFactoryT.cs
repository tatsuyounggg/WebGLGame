using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudFactoryT : MonoBehaviour
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
}

public void MakeCloud(Collider2D collider){
  GameObject newobj = Instantiate(cloudPrefab) as GameObject;
  obj = collider.gameObject;
  newobj.transform.position = new Vector3(obj.transform.position.x,obj.transform.position.y + 4.7f,0);
  list_cloud.Add(newobj);

}

public void MakeGround(Collider2D collider){
  GameObject newobj = Instantiate(groundPrefab) as GameObject;
  obj = collider.gameObject;
  newobj.transform.position = new Vector3(0.0f, obj.transform.position.y + 4.8f,0.0f);
}

public void MakeChoice(Collider2D collider){
  obj = collider.gameObject;
  GameObject newobj = Instantiate(choicePrefab) as GameObject;
  newobj.transform.position = new Vector3(-6.0f ,obj.transform.position.y + 5.0f,0.0f);
  list_cloud.Add(newobj);
  GameObject newobj2 = Instantiate(choicePrefab) as GameObject;
  newobj2.transform.position = new Vector3(6.0f ,obj.transform.position.y + 5.0f,0.0f);
  list_cloud.Add(newobj2);
}

public void DestroyCloud(){
  for(int i = 0; i < list_cloud.Count; i++){
  Destroy(list_cloud[i]);
}
}

}

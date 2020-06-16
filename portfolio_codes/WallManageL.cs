using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManageL : MonoBehaviour
{
  private GameObject player;
  private Vector3 offset;
  // Start is called before the first frame update
  void Start()
  {
    this.player = GameObject.Find("player");
  }



  void Update()
  {
    offset = player.transform.position;
    offset.x = -10.0f;
    offset.y += -5.0f;
    offset.z = 0;
    transform.position = offset;
  }
}

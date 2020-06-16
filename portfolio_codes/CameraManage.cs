using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManage : MonoBehaviour
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
      offset.x = 0;
      offset.y += 3.5f;
      offset.z = -10;
      transform.position = offset;
    }
}

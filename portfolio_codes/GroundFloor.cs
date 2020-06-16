using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFloor : MonoBehaviour
{
  private int player_layer;
  private int ground_floor_layer;

  void Start () {
      player_layer = LayerMask.NameToLayer("Player");
      ground_floor_layer = LayerMask.NameToLayer("GroundFloor");
  }

  private void OnChildTriggerEnter2D(Collider2D c) {
      if (c.gameObject.tag == "check") {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
           // Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer);
         }
  }

  private void OnChildTriggerExit2D(Collider2D c) {
    // if (c.gameObject.tag == "check") {
    //      Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer, false);
    //    }
      if (c.gameObject.tag == "groundcheck") {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;

          // Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer, false);
      }
      
  }
  private void OnTriggerEnter2D(Collider2D c) {
      if (c.gameObject.tag == "groundcheck") {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
          // Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer, false);
      }
  }

}

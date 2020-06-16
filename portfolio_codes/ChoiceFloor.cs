using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceFloor : MonoBehaviour
{
  private int player_layer;
  private int choice_floor_layer;

  void Start () {
      player_layer = LayerMask.NameToLayer("Player");
      choice_floor_layer = LayerMask.NameToLayer("ChoiceFloor");
  }

  private void OnChildTriggerEnter2D(Collider2D c) {
      if (c.gameObject.tag == "check") {
           Physics2D.IgnoreLayerCollision(player_layer, choice_floor_layer);
         }
  }

  private void OnChildTriggerExit2D(Collider2D c) {
      if (c.gameObject.tag == "groundcheck") {
          Physics2D.IgnoreLayerCollision(player_layer, choice_floor_layer, false);
      }
  }
}

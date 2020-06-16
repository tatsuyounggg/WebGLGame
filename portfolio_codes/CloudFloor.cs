using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudFloor : MonoBehaviour
{
    private int player_layer;
    private int cloud_floor_layer;

    void Start () {
        player_layer = LayerMask.NameToLayer("Player");
        cloud_floor_layer = LayerMask.NameToLayer("CloudFloor");
    }

    private void OnChildTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "check") {
             Physics2D.IgnoreLayerCollision(player_layer, cloud_floor_layer);
           }
    }

    private void OnChildTriggerExit2D(Collider2D c) {
        if (c.gameObject.tag == "groundcheck") {
            Physics2D.IgnoreLayerCollision(player_layer, cloud_floor_layer, false);

        }
    }
}

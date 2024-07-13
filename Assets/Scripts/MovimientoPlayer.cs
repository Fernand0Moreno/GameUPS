using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
   private BoxCollider2D bodyBox;
   private RaycastHit2D hit;
   private Vector3 movePlyr;

   public float speed;

   private void Start(){
    bodyBox = GetComponent<BoxCollider2D>();
   }

   //movPer
   //propio de unity
   void FixedUpdate(){
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        movePlyr = new Vector3(hor * speed, ver * speed, 0);

        transform.Translate(movePlyr.x, movePlyr.y,0);


   }
}

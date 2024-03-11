using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowTrail;
    
    
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "SnowGround")
            snowTrail.Play();
        }
   
    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "SnowGround")
            snowTrail.Stop();
        }
}

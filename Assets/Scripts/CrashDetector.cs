using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 1.5f;
    [SerializeField] ParticleSystem hitEffect;
    bool playSFX = false;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "SnowGround" && !playSFX){
            playSFX = true;
            FindObjectOfType<PlayerController>().DisableControls();
            hitEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delayTime);
            }    
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
        }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    public AudioSource hitEnemy;

    // Start is called before the first frame update
    void Start()
    {
        hitEnemy = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("PlayerHands")){
            Invoke("killMonster", 0.0f);
        }
    }

    void killMonster(){
        hitEnemy.Play(0);
        Destroy(gameObject);
    }
}

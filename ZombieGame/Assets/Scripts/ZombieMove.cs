using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public int speed;
    private Vector3 player;

    public AudioClip[] zombieSound;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = new Vector3(0, 0, 0);
        audioSource.clip = zombieSound[Random.Range(0, 2)];
        audioSource.Play();
    }

    void Update()
    {
        transform.LookAt(player);
        transform.position = Vector3.MoveTowards(this.transform.position, player, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            this.GetComponent<Animator>().SetTrigger("Attack");
            audioSource.PlayOneShot(zombieSound[2]);
            speed = 0;
        }
    }
}

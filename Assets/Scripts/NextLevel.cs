using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject nextLevel;
    public GameObject player;
    AudioSource screamSound;
    // Start is called before the first frame update
    void Start()
    {
        screamSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        nextLevel.SetActive(true);
        if (nextLevel.name == "Screamer")
        {
            screamSound.Play();
            player.SetActive(false);
            Cursor.visible = true;
        }
        else
        {
            transform.parent.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject title;
    public GameObject background;
    public GameObject Level1;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        title.SetActive(false);
        background.SetActive(true);
        Level1.SetActive(true);
        player.SetActive(true);
        gameObject.SetActive(false);
    }
}

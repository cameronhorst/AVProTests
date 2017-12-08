using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;


public class VideoStreamer : MonoBehaviour {

    MediaPlayer player;
    public string siteURL;
    public string fileName;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<MediaPlayer>();	
	}
	


	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.OpenVideoFromFile(MediaPlayer.FileLocation.AbsolutePathOrURL, siteURL + fileName, true);
        }
	}
}

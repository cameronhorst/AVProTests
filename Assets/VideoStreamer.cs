using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;
using UnityEngine.UI;

public class VideoStreamer : MonoBehaviour {

    MediaPlayer player;
    public InputField siteURL;
    public InputField fileName;


	// Use this for initialization
	void Start ()
    {
        player = GetComponent<MediaPlayer>();	
	}
	
    public void PlayFromStreamingAssets()
    {
        player.OpenVideoFromFile(MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, fileName.text, true);
    }

    public void PlayFromURL()
    {
        player.OpenVideoFromFile(MediaPlayer.FileLocation.AbsolutePathOrURL, siteURL.text + fileName.text, true);
    }

	// Update is called once per frame
	void Update ()
    {

	}
}

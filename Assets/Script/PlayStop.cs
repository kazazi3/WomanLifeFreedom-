using UnityEngine;
using UnityEngine.Video;

public class PlayStop : MonoBehaviour
{
    private VideoPlayer Video;
    public bool toggle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Video = gameObject.GetComponent<VideoPlayer>();
        gameObject.SetActive(false);
        if (Video.isPlaying)
        {
            Video.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayStopVideo()
    {
        toggle = !toggle;

        if (toggle)
        {
            gameObject.SetActive(true);
            Video.Play();
        }

        else
        {
            Video.Pause();
        }

    }
}

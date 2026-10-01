using UnityEngine;
using UnityEngine.UI;

public class ShowPicture : MonoBehaviour
{
    private GameObject Picture;
    public bool toggle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Picture = this.gameObject;
        if (gameObject.activeSelf)
        {
            Picture.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowHidePicture()
    {
        toggle = !toggle;

        if (toggle)
        {
            Picture.SetActive(true);
        }

        else
        {
            Picture.SetActive(false);
        }

    }
}

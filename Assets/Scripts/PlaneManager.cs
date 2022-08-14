using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlaneManager : MonoBehaviour
{

    //this is our floor tile.
    [SerializeField]
    private Material _planeMaterial;

    [SerializeField]
    private Button[] _rawImages;

    [SerializeField]
    private Texture[] _textures;


    // Awake is called as soon as the app starts.
    void Awake()
    {


        for(int i=0; i < 5; i++) {
            addImageListeners(i);
        }
    }

    void onButtonClick(int i) {
        _planeMaterial.mainTexture=_textures[i];
    }

    void addImageListeners(int i)
    {
        _rawImages[i].onClick.AddListener(() => onButtonClick(i));
    }
}
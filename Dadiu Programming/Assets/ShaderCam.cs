using UnityEngine;
using System.Collections;

public class ShaderCam : MonoBehaviour {

    public Material mat;

    public bool funky;


    void Awake()
    {
        funky = false;
    }


    // Called by the camera to apply the image effect
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if(funky)
        {
            mat.SetMatrix("_ViewProjectInverse", (GetComponent<Camera>().projectionMatrix * GetComponent<Camera>().worldToCameraMatrix).inverse);
            Graphics.Blit(source, destination, mat);
        }
        
    }
}

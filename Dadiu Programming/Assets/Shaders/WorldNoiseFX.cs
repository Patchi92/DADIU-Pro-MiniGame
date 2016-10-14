using UnityEngine;
using System.Collections;

public class WorldNoiseFX : MonoBehaviour {

	public Material mat;



	// Called by the camera to apply the image effect
	void OnRenderImage (RenderTexture source, RenderTexture destination){

		mat.SetMatrix("_ViewProjectInverse", (GetComponent<Camera>().projectionMatrix * GetComponent<Camera>().worldToCameraMatrix).inverse);

		//mat is the material containing your shader
		Graphics.Blit(source,destination,mat);
	}

	
}

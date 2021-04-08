using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct CameraTextureMap {
	public Camera cam;
	public Material mat;
}

public class PortalTextureSetup : MonoBehaviour {

	public CameraTextureMap[] cameraTextures;

	// Use this for initialization
	void Start () {
		foreach (CameraTextureMap map in cameraTextures) {
			if (map.cam.targetTexture != null) {
				map.cam.targetTexture.Release();
			}

			map.cam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
			map.mat.mainTexture = map.cam.targetTexture;
		}
	}
	
}
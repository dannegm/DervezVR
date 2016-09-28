using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraController : MonoBehaviour {

	public Camera LeftEye;
	public Camera RightEye;
	public GUIStyle OculusStyle;

	public float FieldOfView;

	private float width;
	private float height;
	private Rect guirect;

	void Start () {
	}

	void Update () {
		LeftEye.fieldOfView = FieldOfView;
		RightEye.fieldOfView = FieldOfView;
	}

	void OnGUI () {
		width = Screen.width;
		height = Screen.height;
		guirect = new Rect (0, 0, width, height);
		GUI.Box (guirect, "", OculusStyle);
	}
}

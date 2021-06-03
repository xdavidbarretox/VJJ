using UnityEngine;
using System.Collections;

public class UI_behavior : MonoBehaviour
{
	public void say_hello()
	{
		Debug.Log ("Hello mdfkrs");
	}

	GameObject avatar;
	GameObject rash;
	//GameObject jaket;
	public Texture2D XD;

	void Start ()
	{
		avatar = GameObject.Find ("animated");
		rash = GameObject.Find ("avatar:chest");
		//jaket = GameObject.Find ("avatar:jakect");

		//change_look ();
		//change_cloth ("NoGi");
	}

	public void play_movement(string Movement)
	{
		switch (Movement) 
		{
			case "Test":
				avatar.GetComponent<Animation>().Play ("Kimura");
				break;
		}
	}

	public void change_look()
	{
		change_texture (rash, "WhiteRash", "");
	}

	public void change_texture(GameObject Go, string DifuseMap, string NormalMap)
	{
		Texture Texture_0 = new Texture();
		Texture_0 = Resources.Load("Textures/" + DifuseMap) as Texture;
		Go.GetComponent<Renderer>().material.SetTexture("_MainTex", Texture_0);

		/*
		Texture Texture_1 = new Texture();
		Texture_1 = Resources.Load("Textures/" + NormalMap) as Texture;
		Go.renderer.material.SetTexture("_BumpMap", Texture_1);
		*/
	}

	public void change_cloth(string Mode)
	{
		rash.SetActive ((Mode == "NoGi") || (Mode == "MMA"));
		//jaket.SetActive ((Mode == "Gi"));
		/*
		switch (Mode)
		{
		case "Gi":
			rash.SetActive (false);
			jaket.SetActive (true);
			break;
		case "NoGi":
			break;
		case "MMA":
			break;
		}
		*/
	}
}
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {


	public GUISkin skin;
	public int slotsX, slotsY;
	public List<Item> inventory = new List<Item>();
	public List<Item> slots = new List<Item>();
	private ItemDatabase db;
	private bool showInventory;

	// Use this for initialization
	void Start () {
		//define slots
		slotsX = 5;
		slotsY = 4;


		for(int i = 0; i < slotsY * slotsX; i++){
			slots.Add(new Item());
		}

		db = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();


		inventory.Add(db.items[0]);
		inventory.Add(db.items[1]);

	}

	// Update is called once per frame
	void Update(){
		if(Input.GetButtonDown("Inventory")){
				showInventory = !showInventory;
		}
	}



	void OnGUI(){

		GUI.skin = skin;
		if(showInventory)
			DrawInventory();
	}

	void DrawInventory(){
			for(int x = 0; x < slotsX; x++){
				for(int y = 0; y < slotsY; y++){
					GUI.Box(new Rect(x * 60, y * 60, 50, 50), "", skin.GetStyle("Slot"));
				}
			}
	}
}

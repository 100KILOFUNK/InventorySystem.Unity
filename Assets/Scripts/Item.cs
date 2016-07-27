using UnityEngine;
using System.Collections;


[System.Serializable]
public class Item {
		public string itemName;
		public int itemID;
		public string itemDesc;
		public Texture2D itemIcon;
		public ItemType itemType;

		public enum ItemType{
			Readable,
			Watchable,
			Consumeable,
			Tools
		}

		public Item(string name, int ID, string desc, ItemType type){
			itemName = name;
			itemID = ID;
			itemDesc = desc;
			itemType = type;
			itemIcon = Resources.Load<Texture2D>("ItemIcons/" + name);
		}

		public Item(){

		}

		
}

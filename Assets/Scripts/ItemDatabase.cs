using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

		public List<Item> items = new List<Item>();

		void Start(){
			print("DB start");
			items.Add(new Item("Book", 0, "Old Austrian folktale", Item.ItemType.Readable));
			items.Add(new Item("Scroll", 0, "Eerie Note found in the attic", Item.ItemType.Readable));
		}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TableScript : MonoBehaviour {

	public Transform table;
	public Transform cellsFolder;
	public int n = 5;
	public float gap;
	public Cell sample;

	private void Clear(){
		cellsFolder.Children().ForEach(e => Extensions.Destroy(e.gameObject)); 	
	}

	[ContextMenu("Generate")]
	public void Generate() {
		Clear();
		table.localScale = new Vector3(n + gap, n + gap, 1);
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				var newCell = Instantiate(sample);
				newCell.transform.SetParent(cellsFolder);
				newCell.transform.localPosition = new Vector3((-n + 1f) / 2 + j, (-n + 1f) / 2 + i, -1);
				newCell.transform.localScale = (Vector3.one * (1 - gap)).Change(z: 1);
			}
		}
	}
		
}

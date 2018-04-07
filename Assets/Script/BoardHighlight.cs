using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardHighlight : MonoBehaviour {
    public static BoardHighlight Instance { set; get; }

    public GameObject highlightPrefab;
    private List<GameObject> highlights;


    private void Start() {
        Instance = this;
        highlights = new List<GameObject>();
    }

    /* Finds and returns the first that matches the condition of !g.activeself
     * If doesn't find anything, 
     * 
     */
    private GameObject GetHighlight() {
        GameObject go = highlights.Find(g => !g.activeSelf);
        if (go == null) {
            go = Instantiate(highlightPrefab);
            highlights.Add(go);
        }

        return go;
    }

    public void HighlightLegalMoves(bool[,] moves) {
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (moves[i, j]) {
                    GameObject go = GetHighlight();
                    go.SetActive(true);
                    go.transform.position = new Vector3(i + 0.5f, 0, j + 0.5f);
                }
            }
        }
    }

    public void HighlightsOff() {
        foreach(GameObject g in highlights) {
            g.SetActive(false);
        }
    }
}

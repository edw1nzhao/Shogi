using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public static Controller Instance { set; get; }
   
    private bool[,] legalMoves { set; get; }

    private const float TILE_SIZE = 1.0f;
    private const float TILE_OFFSET = 0.5f;

    public ShogiPiece[,] ShogiPieces { set; get; }
    private ShogiPiece currPiece;

    private int tileX = -1;
    private int tileZ = -1;

    public List<GameObject> shogiPrefabs;
    private List<GameObject> shogiOnBoard;

    public bool whiteTurn = true;

    private void Start() {
        Instance = this;
        LoadPieces();
    }

    private void Update() {
        UpdateMouse();
        CreateBoard();

        if (Input.GetMouseButtonDown(0)) {
            if (tileX >= 0 && tileZ >= 0) {
                if (currPiece == null) {
                    SelectPiece(tileX, tileZ);
                } else {
                    MovePiece(tileX, tileZ);
                }
            }
        }
    }

    private void SelectPiece(int x, int z) {

        if (ShogiPieces[x, z].White == whiteTurn) {
            legalMoves = ShogiPieces[x, z].LegalMoves();

            currPiece = ShogiPieces[x, z];
            BoardHighlight.Instance.HighlightLegalMoves(legalMoves);

        }
    }

    private void MovePiece(int x, int z) {
        if (legalMoves[x, z]) {
            ShogiPiece s = ShogiPieces[x, z];
            if (s != null && s.White != whiteTurn) {
                shogiOnBoard.Remove(s.gameObject);
                Destroy(s.gameObject);

                if (s.GetType() == typeof(King)) {
                    Debug.Log("GAME OVER");
                    return;
                }
            }
            ShogiPieces[currPiece.x, currPiece.z] = null;
            currPiece.transform.position = GetTileCenter(x, z);
            currPiece.SetPos(x, z);
            ShogiPieces[x, z] = currPiece;
            whiteTurn = !whiteTurn;
        }

        BoardHighlight.Instance.HighlightsOff();
        currPiece = null;
    }

    private void UpdateMouse() {
        if (!Camera.main) {
            return;
        }

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(
            Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("BoardPlane"))) {

            tileX = (int) hit.point.x;
            tileZ = (int) hit.point.z;
        } else {
            tileX = -1;
            tileZ = -1;
        }
    }

    private void CreateShogiPiece(int index, int x, int z, int rot) {
        Quaternion orientation = Quaternion.Euler(0, rot, 0);

        GameObject newPiece = Instantiate(shogiPrefabs[index], GetTileCenter(x, z), orientation) as GameObject;


        newPiece.transform.SetParent(transform);
        ShogiPieces[x, z] = newPiece.GetComponent<ShogiPiece>();
        ShogiPieces[x, z].SetPos(x, z);

        shogiOnBoard.Add(newPiece);
    }

    private void LoadPieces() {
        shogiOnBoard = new List<GameObject>();
        ShogiPieces = new ShogiPiece[9, 9];

        // Black Pieces
        for (int i = 0; i < 9; i++) {
            CreateShogiPiece(5, i, 6, 0);
        }

        CreateShogiPiece(6, 1, 7, 0);
        CreateShogiPiece(0, 7, 7, 0);

        CreateShogiPiece(4, 0, 8, 0);
        CreateShogiPiece(4, 8, 8, 0);

        CreateShogiPiece(3, 1, 8, 0);
        CreateShogiPiece(3, 7, 8, 0);

        CreateShogiPiece(7, 2, 8, 0);
        CreateShogiPiece(7, 6, 8, 0);

        CreateShogiPiece(1, 3, 8, 0);
        CreateShogiPiece(1, 5, 8, 0);

        CreateShogiPiece(2, 4, 8, 0);

        // White Pieces
        for (int i = 0; i < 9; i++) {
            CreateShogiPiece(13, i, 2, 180);
        }


        CreateShogiPiece(8, 1, 1, 180);
        CreateShogiPiece(14, 7, 1, 180);

        CreateShogiPiece(12, 0, 0, 180);
        CreateShogiPiece(12, 8, 0, 180);

        CreateShogiPiece(11, 1, 0, 180);
        CreateShogiPiece(11, 7, 0, 180);

        CreateShogiPiece(15, 2, 0, 180);
        CreateShogiPiece(15, 6, 0, 180);

        CreateShogiPiece(9, 3, 0, 180);
        CreateShogiPiece(9, 5, 0, 180);

        CreateShogiPiece(10, 4, 0, 180);
    }

    private Vector3 GetTileCenter(int x, int z) {
        Vector3 origin = Vector3.zero;

        origin.x += (TILE_SIZE * x) + TILE_OFFSET;
        origin.z += (TILE_SIZE * z) + TILE_OFFSET;

        return origin;
    }

    private void CreateBoard() {
        Vector3 width = Vector3.right * 9;
        Vector3 height = Vector3.forward * 9;

        for (int i = 0; i < 10; i++) {
            Vector3 start = Vector3.forward * i;
            Debug.DrawLine(start, start + width);

            start = Vector3.right * i;
            Debug.DrawLine(start, start + height);
        }

        //Draw selected

        if (tileX >= 0 && tileZ >= 0) {
            Debug.DrawLine(
                Vector3.forward * tileZ + Vector3.right * tileX,
                Vector3.forward * (tileZ + 1) + Vector3.right * (tileX + 1));
            Debug.DrawLine(
                Vector3.forward * (tileZ + 1) + Vector3.right * tileX,
                Vector3.forward * tileZ + Vector3.right * (tileX + 1));
        }
    }
}
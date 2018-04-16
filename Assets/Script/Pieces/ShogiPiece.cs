using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShogiPiece : MonoBehaviour {
    public int x { set; get; }
    public int z { set; get; }
    public bool White;
    public bool Promoted;

    public void SetPos(int x, int z) {
        this.x = x;
        this.z = z;
    }

    public virtual bool[,] LegalMoves() {
        return new bool[9, 9];
    }
}

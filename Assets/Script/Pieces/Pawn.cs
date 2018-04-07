using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ShogiPiece {
    public override bool[,] LegalMoves() {
       
        bool[,] legal = new bool[9, 9];
        ShogiPiece s;

        if (White) {
            if (z != 8) {
                s = Controller.Instance.ShogiPieces[x, z + 1];
                if (s == null || !s.White) {
                    legal[x, z + 1] = true;
                }
            }
        } else {
            if (z != 0) {
                s = Controller.Instance.ShogiPieces[x, z - 1];
                if (s == null || s.White) {
                    legal[x, z - 1] = true;
                }
            }
        }
        return legal;
    }
}

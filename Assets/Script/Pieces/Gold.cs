using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : ShogiPiece {

    public override bool[,] LegalMoves() {
        bool[,] legal = new bool[9, 9];
        ShogiPiece r;
        ShogiPiece s;
        ShogiPiece t;
        ShogiPiece u;
        ShogiPiece v;
        ShogiPiece w;

        if (White) {
            r = Controller.Instance.ShogiPieces[x - 1, z + 1]; 
            s = Controller.Instance.ShogiPieces[x, z + 1];
            t = Controller.Instance.ShogiPieces[x + 1, z + 1];


        } else {

        }
        return legal;

    }
}

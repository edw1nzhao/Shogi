using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancer : ShogiPiece {
    public override bool[,] LegalMoves() {

        bool[,] legal = new bool[9, 9];
        ShogiPiece s;

        if (White) {
            for (int i = z + 1; i < 9; i++) {
                s = Controller.Instance.ShogiPieces[x, i];

                if (s == null) {
                    legal[x, i] = true;
                } else {
                    if (!s.White) {
                        legal[x, i] = true;
                    }

                    break;
                }
            }
        } else {
            for (int i = z - 1; i >= 0; i--) {
                s = Controller.Instance.ShogiPieces[x, i];

                if (s == null) {
                    legal[x, i] = true;
                } else {
                    if (s.White) {
                        legal[x, i] = true;
                    }

                    break;
                }
            }
        }
        return legal;
    }

}

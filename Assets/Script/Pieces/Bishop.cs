using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ShogiPiece {
    public override bool[,] LegalMoves() {

        bool[,] legal = new bool[9, 9];
        ShogiPiece s;

        if (White) {
            int j = z + 1;
            for (int i = x + 1; i < 9; i++) {
                s = Controller.Instance.ShogiPieces[i, j];
                Debug.Log("x" + x);
                Debug.Log("z" + z);
                Debug.Log("j" + j);
                Debug.Log("i" + i);


                if (s != null) {
                    if (s.White) {
                        break;
                    }
                    legal[i, j] = true;
                    Debug.Log("Dick");
                    break;
                }
                legal[i, j] = true;
                j++;
            }
        } else {
            
        }
        return legal;
    }

}

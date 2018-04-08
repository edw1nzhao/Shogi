using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ShogiPiece {
    public override bool[,] LegalMoves() {
        bool[,] legal = new bool[9, 9];
        ShogiPiece s;
        ShogiPiece t;
        int a = x + 1;
        int b = z;
        int c = x - 1;

        if (White) {
            b += 2;

            if (x < 9) {
                s = Controller.Instance.ShogiPieces[a, b];
                if (s == null) {
                    legal[a, b] = true;
                } else {
                    if (!s.White) {
                        legal[a, b] = true;
                    }
                }

                if (x > 0) {
                    t = Controller.Instance.ShogiPieces[c, b];

                    if (t == null) {
                        legal[c, b] = true;
                    } else {
                        if (!t.White) {
                            legal[c, b] = true;
                        }
                    }
                }
            }


        } else {
            b -= 2;


            if (x < 9) {
                s = Controller.Instance.ShogiPieces[a, b];
                if (s == null) {
                    legal[a, b] = true;
                } else {
                    if (s.White) {
                        legal[a, b] = true;
                    }
                }

                if (x > 0) {
                    t = Controller.Instance.ShogiPieces[c, b];

                    if (t == null) {
                        legal[c, b] = true;
                    } else {
                        if (t.White) {
                            legal[c, b] = true;
                        }
                    }
                }
            }
        }
        return legal;
    }

}

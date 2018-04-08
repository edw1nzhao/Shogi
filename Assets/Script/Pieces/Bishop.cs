using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ShogiPiece {
    public override bool[,] LegalMoves() {

        bool[,] legal = new bool[9, 9];
        ShogiPiece UR, UL, DR, DL;

        if (White) {
            int a = z + 1;
            int b = z - 1;

            for (int i = x + 1; i < 9; i++) {
                UR = Controller.Instance.ShogiPieces[i, a];
                if (UR == null) {
                    legal[i, a] = true;
                } else {
                    if (!UR.White) {
                        legal[i, a] = true;
                    }
                    break;
                }

                a++;
            }

            for (int i = x + 1; i < 9; i++) {
                DR = Controller.Instance.ShogiPieces[i, b];
                if (DR == null) {
                    legal[i, b] = true;
                } else {
                    if (!DR.White) {
                        legal[i, b] = true;
                    }
                    break;
                }

                b--;
            }

            a = z + 1;
            b = z - 1;

            for (int i = x - 1; i > 0; i--) {
                UL = Controller.Instance.ShogiPieces[i, a];

                if (UL == null) {
                    legal[i, a] = true;
                } else {
                    if (!UL.White) {
                        legal[i, a] = true;
                    }
                    break;
                }

                a++;
            }

            for (int i = x - 1; i > 0; i--) {
                DL = Controller.Instance.ShogiPieces[i, b];

                if (DL == null) {
                    legal[i, b] = true;
                } else {
                    if (!DL.White) {
                        legal[i, b] = true;
                    }
                    break;
                }

                b--;
            }
        } else {
            int a = z + 1;
            int b = z - 1;

            for (int i = x + 1; i < 9; i++) {
                UR = Controller.Instance.ShogiPieces[i, a];
                if (UR == null) {
                    legal[i, a] = true;
                } else {
                    if (UR.White) {
                        legal[i, a] = true;
                    }
                    break;
                }

                a++;
            }

            for (int i = x + 1; i < 9; i++) {
                DR = Controller.Instance.ShogiPieces[i, b];
                if (DR == null) {
                    legal[i, b] = true;
                } else {
                    if (DR.White) {
                        legal[i, b] = true;
                    }
                    break;
                }

                b--;
            }

            a = z + 1;
            b = z - 1;

            for (int i = x - 1; i > 0; i--) {
                UL = Controller.Instance.ShogiPieces[i, a];

                if (UL == null) {
                    legal[i, a] = true;
                } else {
                    if (UL.White) {
                        legal[i, a] = true;
                    }
                    break;
                }

                a++;
            }

            for (int i = x - 1; i > 0; i--) {
                DL = Controller.Instance.ShogiPieces[i, b];

                if (DL == null) {
                    legal[i, b] = true;
                } else {
                    if (DL.White) {
                        legal[i, b] = true;
                    }
                    break;
                }

                b--;
            }
        }
        return legal;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ShogiPiece
{
    public override bool[,] LegalMoves() {

        bool[,] legal = new bool[9, 9];
        ShogiPiece c;

        if (White) {
            for (int i = z + 1; i < 9; i++) {
                c = Controller.Instance.ShogiPieces[x, i];

                if (c == null) {
                    legal[x, i] = true;
                } else {
                    if (!c.White) {
                        legal[x, i] = true;
                    }
                    break;
                }
            }

            for (int i = z - 1; i > 0; i--) {
                c = Controller.Instance.ShogiPieces[x, i];

                if (c == null) {
                    legal[x, i] = true;
                } else {
                    if (!c.White) {
                        legal[x, i] = true;
                    }
                    break;
                }
            }

            for (int i = x + 1; i < 9; i++) {
                c = Controller.Instance.ShogiPieces[i, z];

                if (c == null) {
                    legal[i, z] = true;
                } else {
                    if (!c.White) {
                        legal[i, z] = true;
                    }
                    break;
                }
            }
            
            for (int i = x - 1; i > 0; i--) {
                c = Controller.Instance.ShogiPieces[i, z];

                if (c == null) {
                    legal[i, z] = true;
                } else {
                    if (!c.White) {
                        legal[i, z] = true;
                    }
                    break;
                }
            }
        } else {
            for (int i = z + 1; i < 9; i++) {
                c = Controller.Instance.ShogiPieces[x, i];

                if (c == null) {
                    legal[x, i] = true;
                } else {
                    if (c.White) {
                        legal[x, i] = true;
                    }
                    break;
                }
            }

            for (int i = z - 1; i > 0; i--) {
                c = Controller.Instance.ShogiPieces[x, i];

                if (c == null) {
                    legal[x, i] = true;
                } else {
                    if (c.White) {
                        legal[x, i] = true;
                    }
                    break;
                }
            }

            for (int i = x + 1; i < 9; i++) {
                c = Controller.Instance.ShogiPieces[i, z];

                if (c == null) {
                    legal[i, z] = true;
                } else {
                    if (c.White) {
                        legal[i, z] = true;
                    }
                    break;
                }
            }

            for (int i = x - 1; i > 0; i--) {
                c = Controller.Instance.ShogiPieces[i, z];

                if (c == null) {
                    legal[i, z] = true;
                } else {
                    if (c.White) {
                        legal[i, z] = true;
                    }
                    break;
                }
            }

        }

        return legal;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver : ShogiPiece {

    public override bool[,] LegalMoves() {
        bool[,] legal = new bool[9, 9];
        ShogiPiece s;
        ShogiPiece t;
        ShogiPiece u;
        ShogiPiece v;
        ShogiPiece w;

        if (White) {
            s = Controller.Instance.ShogiPieces[x - 1, z + 1];
            t = Controller.Instance.ShogiPieces[x, z + 1];
            u = Controller.Instance.ShogiPieces[x + 1, z + 1];

            if (z > 0) {
                v = Controller.Instance.ShogiPieces[x - 1, z - 1];
                w = Controller.Instance.ShogiPieces[x + 1, z - 1];

                if (v == null) {
                    legal[x - 1, z - 1] = true;
                } else {
                    if (!v.White) {
                        legal[x - 1, z - 1] = true;
                    }
                }

                if (w == null) {
                    legal[x + 1, z - 1] = true;
                } else {
                    if (!w.White) {
                        legal[x + 1, z - 1] = true;
                    }
                }
            }

            if (s == null) {
                legal[x - 1, z + 1] = true;
            } else {
                if (!s.White) {
                    legal[x - 1, z + 1] = true;
                }
            }

            if (t == null) {
                legal[x, z + 1] = true;
            } else {
                if (!t.White) {
                    legal[x, z + 1] = true;
                }
            }

            if (u == null) {
                legal[x + 1, z + 1] = true;
            } else {
                if (!u.White) {
                    legal[x + 1, z + 1] = true;
                }
            }

        } else {
            s = Controller.Instance.ShogiPieces[x - 1, z - 1];
            t = Controller.Instance.ShogiPieces[x, z - 1];
            u = Controller.Instance.ShogiPieces[x + 1, z - 1];

            if (s == null) {
                legal[x - 1, z - 1] = true;
            } else {
                if (s.White) {
                    legal[x - 1, z - 1] = true;
                }
            }

            if (t == null) {
                legal[x, z - 1] = true;
            } else {
                if (t.White) {
                    legal[x, z - 1] = true;
                }
            }

            if (u == null) {
                legal[x + 1, z - 1] = true;
            } else {
                if (u.White) {
                    legal[x + 1, z - 1] = true;
                }
            }

            if (z < 8) {
                v = Controller.Instance.ShogiPieces[x - 1, z + 1];
                w = Controller.Instance.ShogiPieces[x + 1, z + 1];

                if (v == null) {
                    legal[x - 1, z + 1] = true;
                } else {
                    if (v.White) {
                        legal[x - 1, z + 1] = true;
                    }
                }

                if (w == null) {
                    legal[x + 1, z + 1] = true;
                } else {
                    if (w.White) {
                        legal[x + 1, z + 1] = true;
                    }
                }

            }
        }

        return legal;
    }
}

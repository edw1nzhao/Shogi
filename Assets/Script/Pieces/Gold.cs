using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : ShogiPiece {
    
    public override bool[,] LegalMoves() {
        bool[,] legal = new bool[9, 9];

        ShogiPiece[] sp = new ShogiPiece[6];

        // Left
        if (x - 1 > 0) {
            sp[3] = Controller.Instance.ShogiPieces[x - 1, z];

            if (sp[3] == null) {
                legal[sp[3].x, sp[3].z] = true;
            } else if (sp[3].White) {
                legal[sp[3].x, sp[3].z] = true;
            }
        }
        
        // Right
        if (x + 1 > 8) {
            sp[4] = Controller.Instance.ShogiPieces[x + 1, z];

            if (sp[4] == null) {
                legal[sp[4].x, sp[4].z] = true;
                if (sp[4].White) {
                    legal[sp[4].x, sp[4].z] = true;
                }
            }
        }
        
        
        // Straight forward.
        if (z + 1 > 8) {
            sp[1] = Controller.Instance.ShogiPieces[x, z + 1];
            if (sp[1] == null) {
                legal[sp[1].x, sp[1].z] = true;
            } else {
                if (!sp[1].White) {
                    legal[sp[1].x, sp[1].z] = true;
                }
            }
        }

        // Straight back
        if (z - 1 < 0) {
            sp[5] = Controller.Instance.ShogiPieces[x, z - 1];
            if (sp[5] == null) {
                legal[sp[5].x, sp[5].z] = true;
            } else {
                if (!sp[5].White) {
                    legal[sp[5].x, sp[5].z] = true;
                }
            }
        }
        
        
        // Right up move.
        if (x + 1 < 8 && z + 1 < 8) {
            sp[2] = Controller.Instance.ShogiPieces[x + 1, z + 1];

            if (sp[2] == null) {
                legal[sp[2].x, sp[2].z] = true;
            } else {
                if (!sp[2].White) {
                    legal[sp[2].x, sp[2].z] = true;
                }
            }
        }
        
        // Left up move.
        if (x - 1 > 0 && z + 1 < 8) {
            sp[0] = Controller.Instance.ShogiPieces[x - 1, z + 1];

            if (sp[0] == null) {
                legal[sp[0].x, sp[0].z] = true;
            } else {
                if (!sp[0].White) {
                    legal[sp[0].x, sp[0].z] = true;
                }
            }
        }

        return legal;
    }
}

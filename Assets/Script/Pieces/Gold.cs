using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : ShogiPiece {
    
    public override bool[,] LegalMoves() {
        bool[,] legal = new bool[9, 9];

        ShogiPiece[] sp = new ShogiPiece[6];

        if (White) {
            // Left
            if (x - 1 > 0) {
                sp[3] = Controller.Instance.ShogiPieces[x - 1, z];

                if (sp[3] == null) {
                    legal[x - 1, z] = true;
                } else if (!sp[3].White) {
                    legal[x - 1, z] = true;
                }
            }

            // Right
            if (x + 1 < 8) {
                sp[4] = Controller.Instance.ShogiPieces[x + 1, z];

                if (sp[4] == null) {
                    legal[x + 1, z] = true;

                } else {
                    if (!sp[4].White) {
                        legal[x + 1, z] = true;
                    }
                }
            }


            // Straight forward.
            if (z + 1 < 8) {
                sp[1] = Controller.Instance.ShogiPieces[x, z + 1];
                if (sp[1] == null) {
                    legal[x, z + 1] = true;
                } else {
                    if (!sp[1].White) {
                        legal[x, z + 1] = true;
                    }
                }
            }

            // Straight back
            if (z - 1 > 0) {
                sp[5] = Controller.Instance.ShogiPieces[x, z - 1];
                if (sp[5] == null) {
                    legal[x, z - 1] = true;
                } else {
                    if (!sp[5].White) {
                        legal[x, z - 1] = true;
                    }
                }
            }


            // Right up move.
            if (x + 1 < 8 && z + 1 < 8) {
                sp[2] = Controller.Instance.ShogiPieces[x + 1, z + 1];

                if (sp[2] == null) {
                    legal[x + 1, z + 1] = true;
                } else {
                    if (!sp[2].White) {
                        legal[x + 1, z + 1] = true;
                    }
                }
            }

            // Left up move.
            if (x - 1 > 0 && z + 1 < 8) {
                sp[0] = Controller.Instance.ShogiPieces[x - 1, z + 1];

                if (sp[0] == null) {
                    legal[x - 1, z + 1] = true;
                } else {
                    if (!sp[0].White) {
                        legal[x - 1, z + 1] = true;
                    }
                }
            }
        } else {
            // Left
            if (x - 1 > 0) {
                sp[3] = Controller.Instance.ShogiPieces[x - 1, z];

                if (sp[3] == null) {
                    legal[x - 1, z] = true;
                } else if (sp[3].White) {
                    legal[x - 1, z] = true;
                }
            }

            // Right
            if (x + 1 < 8) {
                sp[4] = Controller.Instance.ShogiPieces[x + 1, z];

                if (sp[4] == null) {
                    legal[x + 1, z] = true;

                } else {
                    if (sp[4].White) {
                        legal[x + 1, z] = true;
                    }
                }
            }


            // Straight forward.
            if (z + 1 < 8) {
                sp[1] = Controller.Instance.ShogiPieces[x, z + 1];
                if (sp[1] == null) {
                    legal[x, z + 1] = true;
                } else {
                    if (sp[1].White) {
                        legal[x, z + 1] = true;
                    }
                }
            }

            // Straight back
            if (z - 1 > 0) {
                sp[5] = Controller.Instance.ShogiPieces[x, z - 1];
                if (sp[5] == null) {
                    legal[x, z - 1] = true;
                } else {
                    if (sp[5].White) {
                        legal[x, z - 1] = true;
                    }
                }
            }


            // Right up move.
            if (x + 1 < 8 && z - 1 > 0) {
                sp[2] = Controller.Instance.ShogiPieces[x + 1, z - 1];

                if (sp[2] == null) {
                    legal[x + 1, z - 1] = true;
                } else {
                    if (sp[2].White) {
                        legal[x + 1, z - 1] = true;
                    }
                }
            }

            // Left up move.
            if (x - 1 > 0 && z - 1 < 8) {
                sp[0] = Controller.Instance.ShogiPieces[x - 1, z - 1];

                if (sp[0] == null) {
                    legal[x - 1, z - 1] = true;
                } else {
                    if (sp[0].White) {
                        legal[x - 1, z - 1] = true;
                    }
                }
            }
        }


        return legal;
    }
}

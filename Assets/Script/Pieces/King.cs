using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ShogiPiece {

    public override bool[,] LegalMoves() {
        bool[,] legal = new bool[9, 9];

        ShogiPiece[] sp = new ShogiPiece[8];


        if (White) {
            if (x - 1 > 0) {
                sp[0] = Controller.Instance.ShogiPieces[x - 1, z];
                if (sp[0] == null) {
                    legal[x - 1, z] = true;
                } else if (!sp[0].White) {
                    legal[x - 1, z] = true;
                }

                if (z + 1 < 9) {
                    sp[1] = Controller.Instance.ShogiPieces[x - 1, z + 1];
                    sp[2] = Controller.Instance.ShogiPieces[x, z + 1];

                    if (sp[1] == null) {
                        legal[x - 1, z + 1] = true;
                    } else if (!sp[1].White) {
                        legal[x - 1, z + 1] = true;
                    }

                    if (sp[2] == null) {
                        legal[x, z + 1] = true;
                    } else if (!sp[2].White) {
                        legal[x, z + 1] = true;
                    }
                }

                if (z - 1 >= 0) {
                    sp[3] = Controller.Instance.ShogiPieces[x - 1, z - 1];
                    sp[4] = Controller.Instance.ShogiPieces[x, z - 1];

                    if (sp[3] == null) {
                        legal[x - 1, z - 1] = true;
                    } else if (!sp[3].White) {
                        legal[x - 1, z - 1] = true;
                    }

                    if (sp[4] == null) {
                        legal[x, z - 1] = true;
                    } else if (!sp[4].White) {
                        legal[x, z - 1] = true;
                    }
                }
            }

            if (x + 1 < 9) {
                sp[5] = Controller.Instance.ShogiPieces[x + 1, z];

                if (sp[5] == null) {
                    legal[x + 1, z ] = true;
                } else if (!sp[5].White) {
                    legal[x + 1, z] = true;
                }


                if (z + 1 < 9) {
                    sp[6] = Controller.Instance.ShogiPieces[x + 1, z + 1];
                    if (sp[6] == null) {
                        legal[x + 1, z + 1] = true;
                    } else if (!sp[6].White) {
                        legal[x + 1, z + 1] = true;
                    }
                }

                if (z - 1 >= 0) {
                    sp[7] = Controller.Instance.ShogiPieces[x + 1, z - 1];
                    if (sp[7] == null) {
                        legal[x + 1, z - 1] = true;
                    } else if (!sp[7].White) {
                        legal[x + 1, z - 1] = true;
                    }
                }
            }
        } else {
            if (x - 1 > 0) {
                sp[0] = Controller.Instance.ShogiPieces[x - 1, z];
                if (sp[0] == null) {
                    legal[x - 1, z] = true;
                } else if (sp[0].White) {
                    legal[x - 1, z] = true;
                }

                if (z + 1 < 9) {
                    sp[1] = Controller.Instance.ShogiPieces[x - 1, z + 1];
                    sp[2] = Controller.Instance.ShogiPieces[x, z + 1];

                    if (sp[1] == null) {
                        legal[x - 1, z + 1] = true;
                    } else if (sp[1].White) {
                        legal[x - 1, z + 1] = true;
                    }

                    if (sp[2] == null) {
                        legal[x, z + 1] = true;
                    } else if (sp[2].White) {
                        legal[x, z + 1] = true;
                    }
                }

                if (z - 1 >= 0) {
                    sp[3] = Controller.Instance.ShogiPieces[x - 1, z - 1];
                    sp[4] = Controller.Instance.ShogiPieces[x, z - 1];

                    if (sp[3] == null) {
                        legal[x - 1, z - 1] = true;
                    } else if (sp[3].White) {
                        legal[x - 1, z - 1] = true;
                    }

                    if (sp[4] == null) {
                        legal[x, z - 1] = true;
                    } else if (sp[4].White) {
                        legal[x, z - 1] = true;
                    }
                }
            }

            if (x + 1 < 9) {
                sp[5] = Controller.Instance.ShogiPieces[x + 1, z];

                if (sp[5] == null) {
                    legal[x + 1, z] = true;
                } else if (sp[5].White) {
                    legal[x + 1, z] = true;
                }


                if (z + 1 < 9) {
                    sp[6] = Controller.Instance.ShogiPieces[x + 1, z + 1];
                    if (sp[6] == null) {
                        legal[x + 1, z + 1] = true;
                    } else if (sp[6].White) {
                        legal[x + 1, z + 1] = true;
                    }
                }

                if (z - 1 >= 0) {
                    sp[7] = Controller.Instance.ShogiPieces[x + 1, z - 1];
                    if (sp[7] == null) {
                        legal[x + 1, z - 1] = true;
                    } else if (sp[7].White) {
                        legal[x + 1, z - 1] = true;
                    }
                }
            }
        }

        return legal;
    }

}
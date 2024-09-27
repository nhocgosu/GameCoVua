
using UnityEngine;

public class ChessGameManager : MonoBehaviour
{
  private ChessPiece selectedPiece; // Luu quan co b da bam

  public void SelectedPiece (ChessPiece piece) {
    selectedPiece = piece;
    Debug.Log ("Quam co da chon" + selectedPiece.name);
  }
}


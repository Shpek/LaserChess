using System.Collections.Generic;
using UnityEngine;

public class Player
{
	
	private readonly string _name;
	private Game _game;
	private IList<Piece> _pieces;

	public Player(Game game, string name, IList<Piece> pieces)
	{
		_name = name;
		_game = game;
		_pieces = pieces;
	}
	
	public void StartTurn()
	{
		Debug.Log($"{_name} start turn");
	}

	public void Update()
	{
		
	}
}

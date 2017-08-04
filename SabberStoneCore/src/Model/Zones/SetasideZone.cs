﻿using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Special zone for entities which are generated during the game.
	/// Any <see cref="EntityChoice"/> holds a generated choice set, which entities 
	/// are stored in this zone. 
	/// The entity which is chosen will be moved from this zone into another, for 
	/// example <see cref="HandZone"/>. (Depends on <see cref="EntityChoice.ChoiceType"/>)
	/// </summary>
	/// <seealso cref="SabberStoneCore.Model.Zones.Zone{SabberStoneCore.Model.IPlayable}" />
	public class SetasideZone : Zone<IPlayable>
	{
		/// <summary>Initializes a new instance of the <see cref="SetasideZone"/> class.</summary>
		/// <param name="game">The game which contains the zone.</param>
		/// <param name="controller">The controller which owns the zone.</param>
		/// <param name="type">The kind of zone.</param>
		/// <autogeneratedoc />
		public SetasideZone(Game game, Controller controller, EZone type) : base(game, controller, type)
		{
		}
	}
}
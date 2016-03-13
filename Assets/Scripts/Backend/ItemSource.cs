namespace BDChef
{
	/// <summary>
	/// Identifies how a particular item can be acquired.
	/// </summary>
	public enum ItemSource : int
	{
		/// <summary>
		/// This indicates an error.
		/// </summary>
		Invalid = Const.INVALID_ENUM,

		/// <summary>
		/// Crafted by the player.
		/// </summary>
		Prepared,

		/// <summary>
		/// Gathered by the player or a worker.
		/// </summary>
		Gathered,

		/// <summary>
		/// Can be purchased from an NPC.
		/// </summary>
		Purchased,

		/// <summary>
		/// Fish that was dried or purchased in the AH.
		/// </summary>
		DriedFish
	}
}
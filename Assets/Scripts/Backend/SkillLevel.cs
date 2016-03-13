namespace BDChef
{
	/// <summary>
	/// Identifies a tier for a skill's level.
	/// </summary>
	public enum SkillLevel
	{
		/// <summary>
		/// This indicates an error.
		/// </summary>
		Invalid = Const.INVALID_ENUM,

		/// <summary>
		/// The starting skill level.
		/// </summary>
		Beginner,

		/// <summary>
		/// Good.
		/// </summary>
		Apprentice,

		/// <summary>
		/// Better.
		/// </summary>
		Experienced,

		/// <summary>
		/// Best.
		/// </summary>
		Artisan
	}
}
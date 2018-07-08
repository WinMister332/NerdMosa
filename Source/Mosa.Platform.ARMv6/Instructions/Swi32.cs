// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.ARMv6.Instructions
{
	/// <summary>
	/// Swi32 - Supervisor Call
	/// </summary>
	/// <seealso cref="Mosa.Platform.ARMv6.ARMv6Instruction" />
	public sealed class Swi32 : ARMv6Instruction
	{
		public override int ID { get { return 659; } }

		internal Swi32()
			: base(1, 3)
		{
		}
	}
}

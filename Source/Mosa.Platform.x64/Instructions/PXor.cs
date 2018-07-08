// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Instructions
{
	/// <summary>
	/// PXor
	/// </summary>
	/// <seealso cref="Mosa.Platform.x64.X64Instruction" />
	public sealed class PXor : X64Instruction
	{
		public override int ID { get { return 509; } }

		internal PXor()
			: base(1, 2)
		{
		}

		public static readonly LegacyOpCode LegacyOpcode = new LegacyOpCode(new byte[] { 0x66, 0x0F, 0xEF });

		public override bool ThreeTwoAddressConversion { get { return true; } }
	}
}

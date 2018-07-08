// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// MulSigned32
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class MulSigned32 : BaseIRInstruction
	{
		public override int ID { get { return 116; } }

		public MulSigned32()
			: base(2, 1)
		{
		}

		public override bool IsCommutative { get { return true; } }
	}
}

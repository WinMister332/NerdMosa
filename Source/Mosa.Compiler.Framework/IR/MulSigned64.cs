// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// MulSigned64
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class MulSigned64 : BaseIRInstruction
	{
		public override int ID { get { return 117; } }

		public MulSigned64()
			: base(2, 1)
		{
		}

		public override bool IsCommutative { get { return true; } }
	}
}

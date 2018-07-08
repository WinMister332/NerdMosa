// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// LogicalAnd64
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class LogicalAnd64 : BaseIRInstruction
	{
		public override int ID { get { return 91; } }

		public LogicalAnd64()
			: base(2, 1)
		{
		}

		public override bool IsCommutative { get { return true; } }
	}
}

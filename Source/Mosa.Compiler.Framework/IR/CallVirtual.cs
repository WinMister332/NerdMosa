// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// CallVirtual
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class CallVirtual : BaseIRInstruction
	{
		public override int ID { get { return 17; } }

		public CallVirtual()
			: base(0, 0)
		{
		}

		public override bool VariableOperands { get { return true; } }
	}
}

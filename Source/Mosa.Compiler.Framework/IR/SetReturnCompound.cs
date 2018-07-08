// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// SetReturnCompound
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class SetReturnCompound : BaseIRInstruction
	{
		public override int ID { get { return 136; } }

		public SetReturnCompound()
			: base(1, 0)
		{
		}

		public override FlowControl FlowControl { get { return FlowControl.Return; } }
	}
}

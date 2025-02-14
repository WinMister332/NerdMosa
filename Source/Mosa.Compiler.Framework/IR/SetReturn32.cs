// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR;

/// <summary>
/// SetReturn32
/// </summary>
/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
public sealed class SetReturn32 : BaseIRInstruction
{
	public SetReturn32()
		: base(1, 0)
	{
	}

	public override FlowControl FlowControl => FlowControl.Return;
}

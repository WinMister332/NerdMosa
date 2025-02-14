// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR;

/// <summary>
/// Call
/// </summary>
/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
public sealed class Call : BaseIRInstruction
{
	public Call()
		: base(0, 0)
	{
	}

	public override FlowControl FlowControl => FlowControl.Call;

	public override bool VariableOperands => true;
}
